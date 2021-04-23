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
using GSBCarpooling.Repositoies;

namespace GSBCarpooling
{
    public partial class FEN_GestionTrajets : Form
    {
        public FEN_GestionTrajets()
        {
            InitializeComponent();
        }

        private void FEN_GestionTrajets_Load(object sender, EventArgs e)
        {
            chargerTable();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Actualiser_Click(object sender, EventArgs e)
        {
            this.chargerTable();
        }

        private void BTN_Nouveau_Click(object sender, EventArgs e)
        {
            Form newTrajet = new FEN_ProposerTrajet(modeOuverture.CREATION);
            newTrajet.ShowDialog();

            this.chargerTable();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;
            Form newTrajet = new FEN_ProposerTrajet(modeOuverture.MODIFICATION, id);
            newTrajet.ShowDialog();

            this.miseAJourLigneEnCours();

        }

        private void chargerTable()
        {
            TABLE_Trajets.Rows.Clear();

            string rSQL =
                "SELECT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Trajet_Commentaire, Vehicule_Id, Utilisateur_Nom, Utilisateur_Prenom " +
                "FROM TRAJET T " +
                "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                "ORDER BY Trajet_Date DESC, Trajet_HeureDepart DESC";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;

                TABLE_Trajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3], (int)dataRecord[4], (string)dataRecord[5], (string)dataRecord[6]);
            }
            data.Close();
            cmd.Cancel();
        }

        private void miseAJourLigneEnCours()
        {
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;

            string rSQL =
                "SELECT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Trajet_Commentaire, Vehicule_Id, Utilisateur_Nom, Utilisateur_Prenom " +
                "FROM TRAJET T " +
                "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                "WHERE Trajet_id = " + id + " " +
                "ORDER BY Trajet_Date DESC, Trajet_HeureDepart DESC";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == false) return;

            var dataRecord = (IDataRecord)data;
            TABLE_Trajets.CurrentRow.Cells[0].Value = (int)dataRecord[0];
            TABLE_Trajets.CurrentRow.Cells[1].Value = (DateTime)dataRecord[1];
            TABLE_Trajets.CurrentRow.Cells[2].Value = (DateTime)dataRecord[2];
            TABLE_Trajets.CurrentRow.Cells[3].Value = (int)dataRecord[3];
            TABLE_Trajets.CurrentRow.Cells[4].Value = (int)dataRecord[4];
            TABLE_Trajets.CurrentRow.Cells[5].Value = (string)dataRecord[5];
            TABLE_Trajets.CurrentRow.Cells[6].Value = (int)dataRecord[6];

            data.Close();
            cmd.Cancel();
        }

        private void BTN_Desable_Click(object sender, EventArgs e)
        {
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de vouloir désactiver ce trajet ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (new TrajetRepository()).disable(id);
                this.chargerTable();
            }
        }

        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aPropos = new FEN_APropos();
            aPropos.ShowDialog();
        }

        private void FermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Nouveau_Click_1(object sender, EventArgs e)
        {
            Form newTrajet = new FEN_ProposerTrajet(modeOuverture.CREATION);
            newTrajet.ShowDialog();
            this.chargerTable();
        }

        private void Modifier_Click_1(object sender, EventArgs e)
        {
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;

            Form newTrajet = new FEN_ProposerTrajet(modeOuverture.MODIFICATION, id);
            newTrajet.ShowDialog();
            this.chargerTable();
        }

        private void TABLE_Trajets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;

            Form newTrajet = new FEN_ProposerTrajet(modeOuverture.MODIFICATION, id);
            newTrajet.ShowDialog();
        }

        private void BTN_Disable_Click(object sender, EventArgs e)
        {
            int id = (int)TABLE_Trajets.CurrentRow.Cells[0].Value;

            // Suppression des étapes
            string rSQL = "DELETE FROM ETAPE WHERE Trajet_Id = " + id;

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            int result = cmd.ExecuteNonQuery();
            cmd.Cancel();

            // Suppression des réservation liées aux trajets
            rSQL = "DELETE FROM RESERVER WHERE Trajet_Id = " + id;
            cmd = new SqlCommand(rSQL, Global.dataBase);
            result = cmd.ExecuteNonQuery();
            cmd.Cancel();

            //Suppression du trajet
            switch (Global.user.getTypeUtilisateur()) {
                case "USER":
                    rSQL = "DELETE FROM TRAJET WHERE Utilisateur_Id = " + Global.user.getId() + " AND Trajet_Id = " + id;
                    cmd = new SqlCommand(rSQL, Global.dataBase);
                    result = cmd.ExecuteNonQuery();
                    cmd.Cancel();
                    break;
                case "ADMIN":
                    rSQL = "DELETE FROM TRAJET WHERE Trajet_Id = " + id;
                    cmd = new SqlCommand(rSQL, Global.dataBase);
                    result = cmd.ExecuteNonQuery();
                    cmd.Cancel();
                    break;
                default:
                    rSQL = "DELETE FROM TRAJET WHERE Utilisateur_Id = " + Global.user.getId() + " AND Trajet_Id = " + id;
                    cmd = new SqlCommand(rSQL, Global.dataBase);
                    result = cmd.ExecuteNonQuery();
                    cmd.Cancel();
                    break;
            }

            if (result >= 1)
            {
                MessageBox.Show("Trajet supprimé...");

                TABLE_Trajets.Rows.Clear();

                rSQL =
                    "SELECT T.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Trajet_Commentaire, Vehicule_Id, Utilisateur_Nom, Utilisateur_Prenom " +
                    "FROM TRAJET T " +
                    "JOIN UTILISATEUR U ON U.Utilisateur_Id = T.Utilisateur_Id " +
                    "ORDER BY Trajet_Date DESC, Trajet_HeureDepart DESC";

                cmd = new SqlCommand(rSQL, Global.dataBase);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    var dataRecord = (IDataRecord)data;

                    //rSQL = "Ville_Nom FROM ETAPE WHERE Trajet_Id = " + (int)dataRecord[0] + "AND ordre IN (" + (int)dataRecord[3] + ", " + (int)dataRecord[4] + ")";

                    TABLE_Trajets.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3], (int)dataRecord[4], (string)dataRecord[5], (string)dataRecord[6]);
                }
                cmd.Cancel();
                data.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez recommencer.");
                return;
            }
        }

        private void BTN_Fermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Actualiser_Click_1(object sender, EventArgs e)
        {
            this.chargerTable();
        }
    }
}
