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

namespace GSBCarpooling
{
    public partial class FEN_VosTrajets : Form
    {
        public FEN_VosTrajets()
        {
            InitializeComponent();
        }

        private void FEN_VosTrajets_Load(object sender, EventArgs e)
        {
            this.chargerTable();
        }

        private void chargerTable()
        {
            TABLE_VosTrajets.Rows.Clear();

            // Charge la liste des trajets de l'utilisateur
            string rSQL =
                "SELECT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Ville_Depart, MAX(ordre) " +
                "FROM TRAJET T " +
                "JOIN ETAPE E ON E.Trajet_Id = T.Trajet_Id " +
                "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                "WHERE T.Utilisateur_Id = " + Global.user.getId() + " " +
                "GROUP BY T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Ville_Depart " +
                "ORDER BY Trajet_Date DESC, Trajet_HeureDepart DESC";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_VosTrajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3], (int)dataRecord[4]);
            }
            this.fermetureRequete(cmd, data);

            // Recherche s'il existe une demande de réservation pour ce trajet
            string rSqlReservation = "SELECT R.Trajet_Id, COUNT(R.Trajet_Id) " + 
                "FROM RESERVER R " +
                "JOIN TRAJET T ON T.Trajet_Id = R.Trajet_Id " +
                "WHERE T.Utilisateur_Id = " + Global.user.getId() + " AND accepte IS NULL " + 
                "GROUP BY R.Trajet_Id";

            cmd = new SqlCommand(rSqlReservation, Global.dataBase);
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;

                int idTRajet = (int)dataRecord[0];
                int count = (int)dataRecord[1];

                for (int i = 0; i < TABLE_VosTrajets.Rows.Count - 1; i++)
                {
                    if((int)TABLE_VosTrajets.Rows[i].Cells[0].Value == idTRajet && count != 0)
                    {
                        // S'il existe une demande de réservation en attente de réponse alors on affiche la ligne du trajet en orange
                        TABLE_VosTrajets.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                    }
                }
            }
            this.fermetureRequete(cmd, data);
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = (int)TABLE_VosTrajets.CurrentRow.Cells[0].Value;
            }
            catch (NullReferenceException) { goto Sortir; }

            // Suppression des étapes
            string rSQL = "DELETE FROM ETAPE WHERE Trajet_Id = " + id;

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            int result = cmd.ExecuteNonQuery();
            this.fermetureRequete(cmd);

            //Suppression du trajet
            rSQL = "DELETE FROM TRAJET WHERE Utilisateur_Id = " + Global.user.getId() + " AND Trajet_Id = " + id;
            cmd = new SqlCommand(rSQL, Global.dataBase);
            result = cmd.ExecuteNonQuery();
            this.fermetureRequete(cmd);

            if (result >= 1)
            {
                MessageBox.Show("Trajet supprimé...");

                TABLE_VosTrajets.Rows.Clear();

                rSQL =
                    "SELECT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, MIN(ordre), MAX(ordre) " +
                    "FROM TRAJET T " +
                    "JOIN ETAPE E ON E.Trajet_Id = T.Trajet_Id " +
                    "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                    "WHERE T.Utilisateur_Id = " + Global.user.getId() + " " +
                    "GROUP BY T.Trajet_Id, Trajet_Date, Trajet_HeureDepart " +
                    "ORDER BY Trajet_Date DESC, Trajet_HeureDepart DESC";

                cmd = new SqlCommand(rSQL, Global.dataBase);
                SqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    var dataRecord = (IDataRecord)data;

                    //rSQL = "Ville_Nom FROM ETAPE WHERE Trajet_Id = " + (int)dataRecord[0] + "AND ordre IN (" + (int)dataRecord[3] + ", " + (int)dataRecord[4] + ")";

                    TABLE_VosTrajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (int)dataRecord[3], (int)dataRecord[4]);
                }
                this.fermetureRequete(cmd, data);
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez recommencer.");
                return;
            }
        Sortir:;
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            int id;
            try {
                id = (int)TABLE_VosTrajets.CurrentRow.Cells[0].Value;
            }
            catch (NullReferenceException) { goto Sortir; }

            Form proposerTrajet = new FEN_ProposerTrajet(modeOuverture.MODIFICATION, id);
            proposerTrajet.ShowDialog();
            this.chargerTable();

        Sortir:;
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TABLE_VosTrajets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)TABLE_VosTrajets.CurrentRow.Cells[0].Value;
            Form trajet = new FEN_Trajet(id);
            trajet.ShowDialog();
            this.chargerTable();
        }

        private void fermetureRequete(SqlCommand cmd = null, SqlDataReader data = null)
        {
            if(data != null) data.Close();
            if(cmd != null) cmd.Cancel();
        }
    }
}
