using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GSBCarpooling.Entities;

namespace GSBCarpooling
{
    public partial class FEN_RechercherTrajet : Form
    {
        public FEN_RechercherTrajet()
        {
            InitializeComponent();
        }

        private void FEN_RechercherTrajet_Load(object sender, EventArgs e)
        {
            BTN_Reserver.Visible = false;

            // Paramètrage des dateTimePickers
            dateTimePicker_DateDepart.MinDate = DateTime.Today;
            dateTimePicker_HeureDepart.CustomFormat = "HH:mm";
            dateTimePicker_HeureDepart.Format = DateTimePickerFormat.Custom;

            // Paramètrage des combos
            C_VilleDepart.AutoCompleteMode = AutoCompleteMode.Append;
            C_VilleDepart.AutoCompleteSource = AutoCompleteSource.ListItems;

            C_VilleArrivee.AutoCompleteMode = AutoCompleteMode.Append;
            C_VilleArrivee.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Remplissage des combos de villes
            foreach (Ville ville in Cache.villes)
            {
                C_VilleDepart.Items.Add(ville.getNom());
                C_VilleArrivee.Items.Add(ville.getNom());
            }
        }

        private void BTN_Rechercher_Click(object sender, EventArgs e)
        {
            // Nettoyage de la table avant recherche
            TABLE_Trajets.Rows.Clear();

            // Recherche si un trajet correspond au champ de recherche
            string rSQL =
                "SELECT DISTINCT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Utilisateur_Nom, Utilisateur_Prenom " +
                "FROM TRAJET T " +
                "JOIN ETAPE E ON E.Trajet_Id = T.Trajet_Id " +
                "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                "WHERE Trajet_Date = '"+ dateTimePicker_DateDepart.Value + "' " +
                "AND Trajet_HeureDepart >= '"+ dateTimePicker_HeureDepart.Value + "' " +
                "AND Ville_Depart = '"+ C_VilleDepart.Text +"' " +
                "AND E.Ville_Nom = '"+ C_VilleArrivee.Text +"' " + 
                "AND T.Utilisateur_Id != " + Global.user.getId() + " " +
                "AND Trajet_NbPassagers > ("+
                    "SELECT COUNT(Trajet_Id) "+
                    "FROM RESERVER "+
                    "WHERE Trajet_Id = T.Trajet_Id " +
                    "AND accepte = 1)";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            // Si pas de données, l'utilisateur n'existe pas...
            if (!data.HasRows)
            {
                BTN_Reserver.Visible = false;
                MessageBox.Show("Aucun trajet n'a été trouvé à cette date !");
                data.Close();
                cmd.Cancel();
                return;
            } else
            {
                BTN_Reserver.Visible = true;
            }

            // Remplissage de la table
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_Trajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3], (string)dataRecord[4]);
            }

            data.Close();
            cmd.Cancel();
        }

        private void BTN_Reserver_Click(object sender, EventArgs e)
        {
            // Vérifie si un trajet a été proposé à l'utilisateur à cette date
            DateTime dateTrajet = DateTime.Parse(TABLE_Trajets.CurrentRow.Cells[1].Value.ToString());
            if(this.trajetProposeExiste(dateTrajet))
            {
                MessageBox.Show("Impossible de proposer ce trajet car vous avez déjà un trajet réservé à cette date...");
                return;
            }


            // Réservation du trajet
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;
            
            string rSQL = "INSERT INTO RESERVER (Utilisateur_Id, Trajet_Id) VALUES ('"+ Global.user.getId() +"' , " + id + ")";

            SqlCommand reserverTrajet = new SqlCommand(rSQL, Global.dataBase);

            int result = reserverTrajet.ExecuteNonQuery();

            reserverTrajet.Cancel();

            if (result >= 1)
            {
                MessageBox.Show("Trajet réservé");
                Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez recommencer.");
                return;
            }
        }

        private bool trajetProposeExiste(DateTime dateTrajet)
        {
            string rSQL = "SELECT Trajet_Id " +
                "FROM TRAJET T " +
                "WHERE T.Trajet_Date = '" + dateTrajet + "' " +
                "AND Utilisateur_Id = " + Global.user.getId();

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            // S'il y a un resultat
            if (data.HasRows)
            {
                cmd.Cancel();
                data.Close();
                return true;
            }

            cmd.Cancel();
            data.Close();
            return false;
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
