using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCarpooling
{
    public partial class FEN_Trajet : Form
    {
        private int idTrajet;
        private int nbPlaces;

        public FEN_Trajet(int id)
        {
            InitializeComponent();
            this.idTrajet = id;
        }

        private void FEN_Trajet_Load(object sender, EventArgs e)
        {
            this.Text = "Trajet n° " + idTrajet;

            this.rechercheNbPlacesTrajet();

            // Remplissable de la table des participants 
            this.remplirTableParticipants();

            // Remplissage de la table des demanndes de participation
            this.remplirTableDemandes();

            // Bloque le bouton accepté si le nombre limite de participant est atteint.
            if (this.nbPlaces == TABLE_Participants.RowCount) BTN_Accepter.Enabled = false;
        }

        private void remplirTableParticipants()
        {
            string rSql = "SELECT U.Utilisateur_Id, Utilisateur_Nom, Utilisateur_Prenom " +
                "FROM UTILISATEUR U " +
                "JOIN RESERVER R ON R.Utilisateur_Id = U.Utilisateur_Id " +
                "WHERE Trajet_Id = " + this.idTrajet + " " +
                "AND accepte = 1";

            SqlCommand cmd = new SqlCommand(rSql, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            TABLE_Participants.Rows.Clear();

            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_Participants.Rows.Add((int)dataRecord[0], (string)dataRecord[1], (string)dataRecord[2]);
            }
            this.fermetureRequete(cmd, data);
        }

        private void remplirTableDemandes()
        {
            string rSql = "SELECT U.Utilisateur_Id, Utilisateur_Nom, Utilisateur_Prenom " +
                "FROM UTILISATEUR U " +
                "JOIN RESERVER R ON R.Utilisateur_Id = U.Utilisateur_Id " +
                "WHERE Trajet_Id = " + this.idTrajet + " " +
                "AND accepte IS NULL";

            SqlCommand cmd = new SqlCommand(rSql, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            TABLE_DemandesEnAttente.Rows.Clear();

            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_DemandesEnAttente.Rows.Add((int)dataRecord[0], (string)dataRecord[1], (string)dataRecord[2]);
            }
            this.fermetureRequete(cmd, data);
        }

        private void BTN_Accepter_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = (int)TABLE_DemandesEnAttente.CurrentRow.Cells[0].Value;
                this.reponseDemandeDeReservation(id, true);
                this.actualiserTables();
            }
            catch (NullReferenceException)
            {
                return;
            }
            // Bloque le bouton accepté si le nombre limite de participants est atteint.
            if (this.nbPlaces == TABLE_Participants.RowCount) BTN_Accepter.Enabled = false;
        }

        private void BTN_Refuser_Click(object sender, EventArgs e)
        { 
            try
            {
                int id;
                id = (int)TABLE_DemandesEnAttente.CurrentRow.Cells[0].Value;
                this.reponseDemandeDeReservation(id, false);
                this.actualiserTables();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void reponseDemandeDeReservation(int id, bool reponse)
        {
            string rSql = "UPDATE RESERVER " +
                "SET accepte = " + Convert.ToByte(reponse) + " " +
                "WHERE Trajet_Id = " + this.idTrajet + " " +
                "AND Utilisateur_Id = " + id;

            SqlCommand reponseDemande = new SqlCommand(rSql, Global.dataBase);

            int result = reponseDemande.ExecuteNonQuery();

            if (result >= 1) {
                if (reponse)
                    MessageBox.Show("Réservation acceptée.");
                else
                    MessageBox.Show("Réservation refusée.");
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez recommencer");
            }
        }

        private void rechercheNbPlacesTrajet()
        {
            string rSql = "SELECT Trajet_NbPassagers " +
                "FROM TRAJET " + 
                "WHERE Trajet_Id = " + this.idTrajet;

            SqlCommand cmd = new SqlCommand(rSql, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            data.Read();
            var dataRecord = (IDataRecord)data;

            this.nbPlaces = (byte)dataRecord[0];

            this.fermetureRequete(cmd, data);
        }

        private void actualiserTables()
        {
            this.remplirTableDemandes();
            this.remplirTableParticipants();
        }

        private void fermetureRequete(SqlCommand cmd, SqlDataReader data)
        {
            data.Close();
            cmd.Cancel();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
