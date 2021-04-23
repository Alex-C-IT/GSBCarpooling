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
    public partial class FEN_GestionUsers : Form
    {
        public FEN_GestionUsers()
        {
            InitializeComponent();
        }

        private void FEN_GestionUsers_Load(object sender, EventArgs e)
        {
            this.chargerTable();
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
            Form newUser = new FEN_User(modeOuverture.CREATION);
            newUser.ShowDialog();

            this.chargerTable();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)TABLE_Users.CurrentRow.Cells[0].Value;
            Form newUser = new FEN_User(modeOuverture.MODIFICATION, id);
            newUser.ShowDialog();

            this.miseAJourLigneEnCours();

        }

        private void chargerTable()
        {
            TABLE_Users.Rows.Clear();

            string rSQL =
               "SELECT Utilisateur_Id, Utilisateur_Nom, Utilisateur_Prenom, Utilisateur_Pseudonyme, Utilisateur_Email, Utilisateur_TelMobile, Utilisateur_Rue, Ville_Nom, Ville_CodePostal, TypeUtilisateur_Id " +
               "FROM UTILISATEUR " +
               "WHERE Utilisateur_Actif = 1";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;

                TABLE_Users.Rows.Add((int)dataRecord[0], (string)dataRecord[1], (string)dataRecord[2], (string)dataRecord[3], (string)dataRecord[4], (string)dataRecord[5], (string)dataRecord[6], (string)dataRecord[7], (string)dataRecord[8], (string)dataRecord[9]);
            }
            data.Close();
        }

        private void miseAJourLigneEnCours()
        {
            int id = (int)TABLE_Users.CurrentRow.Cells[0].Value;

            string rSQL =
               "SELECT Utilisateur_Id, Utilisateur_Nom, Utilisateur_Prenom, Utilisateur_Pseudonyme, Utilisateur_Email, Utilisateur_TelMobile, Utilisateur_Rue, Ville_Nom, Ville_CodePostal, TypeUtilisateur_Id " +
               "FROM UTILISATEUR " +
               "WHERE Utilisateur_Id = " + id + " AND Utilisateur_Actif = 1";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == false) return;

            var dataRecord = (IDataRecord)data;
            TABLE_Users.CurrentRow.Cells[0].Value = (int)dataRecord[0];
            TABLE_Users.CurrentRow.Cells[1].Value = (string)dataRecord[1];
            TABLE_Users.CurrentRow.Cells[2].Value = (string)dataRecord[2];
            TABLE_Users.CurrentRow.Cells[3].Value = (string)dataRecord[3];
            TABLE_Users.CurrentRow.Cells[4].Value = (string)dataRecord[4];
            TABLE_Users.CurrentRow.Cells[5].Value = (string)dataRecord[5];
            TABLE_Users.CurrentRow.Cells[6].Value = (string)dataRecord[6];
            TABLE_Users.CurrentRow.Cells[7].Value = (string)dataRecord[7];
            TABLE_Users.CurrentRow.Cells[8].Value = (string)dataRecord[8];
            TABLE_Users.CurrentRow.Cells[9].Value = (string)dataRecord[9];

            data.Close();
        }

        private void BTN_Desable_Click(object sender, EventArgs e)
        {
            int id = (int)TABLE_Users.CurrentRow.Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de vouloir désactiver cet utilisateur ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (new UtilisateurRepository()).disable(id);
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

        private void TABLE_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)TABLE_Users.CurrentRow.Cells[0].Value;
            Form newUser = new FEN_User(modeOuverture.MODIFICATION, id);
            newUser.ShowDialog();

            this.miseAJourLigneEnCours();
        }
    }
}
