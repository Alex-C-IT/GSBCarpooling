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

                //rSQL = "Ville_Nom FROM ETAPE WHERE Trajet_Id = " + (int)dataRecord[0] + "AND ordre IN (" + (int)dataRecord[3] + ", " + (int)dataRecord[4] + ")";

                TABLE_VosTrajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3], (int)dataRecord[4]);
            }
            data.Close();
            cmd.Cancel();
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
            cmd.Cancel();

            //Suppression du trajet
            rSQL = "DELETE FROM TRAJET WHERE Utilisateur_Id = " + Global.user.getId() + " AND Trajet_Id = " + id;
            cmd = new SqlCommand(rSQL, Global.dataBase);
            result = cmd.ExecuteNonQuery();
            cmd.Cancel();

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

                data.Close();
                cmd.Cancel();
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
    }
}
