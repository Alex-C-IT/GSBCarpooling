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
    public partial class FEN_Home : Form
    {
        public FEN_Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form Connexion = new FEN_Login();
            Connexion.ShowDialog();

            // Si pas de log après la fenêtre de connexion alors arret du programme.
            if (!Global.logOK) {
                Application.Exit();
                return;
            }

            // Première connexion ?
            if(Global.user.getPremiereConnexion())
            {
                Form bienvenue = new FEN_PremiereConnexion();
                bienvenue.ShowDialog();
            }

            BTN_AnnulerReservation.Visible = false;

            L_Welcome.Text = String.Format("{0} {1} {2}", (DateTime.Now.Hour >= 18) ? "Bonsoir" : "Bonjour" ,Global.user.getNom(), Global.user.getPrenom());
            if (Global.user.getTypeUtilisateur() != "ADMIN")
                BTN_Admin.Visible = false;

            // Remplissage de la table des réservations
            this.remplirTableReservation();

            // Recherche des demandes de réservation
            this.rechercheDemandeReservation();

        }

        private void FermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aPropos = new FEN_APropos();
            aPropos.ShowDialog();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quitter l'application ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            Form admin = new FEN_Admin();
            admin.ShowDialog();
        }

        private void BTN_Param_Click(object sender, EventArgs e)
        {
            Form param = new FEN_User(modeOuverture.MODIFICATION,Global.user.getId());
            param.ShowDialog();
        }

        private void BTN_GestionCars_Click(object sender, EventArgs e)
        {
            Form proposer = new FEN_ProposerTrajet();
            proposer.ShowDialog();
        }

        private void BTN_VosTrajets_Click(object sender, EventArgs e)
        {
            Form vosTrajets = new FEN_VosTrajets();
            vosTrajets.ShowDialog();
        }

        private void BTN_RechercherTrajet_Click(object sender, EventArgs e)
        {
            Form rechercheTrajet = new FEN_RechercherTrajet();
            rechercheTrajet.ShowDialog();
            this.remplirTableReservation();

        }

        private void BTN_AnnulerReservation_Click(object sender, EventArgs e)
        {
            int id = (int)TABLE_TrajetsReserves.CurrentRow.Cells[0].Value;

            string rSQL = "DELETE FROM RESERVER WHERE Utilisateur_Id = " + Global.user.getId() +" AND Trajet_Id = " + id;

            SqlCommand annulerReservation = new SqlCommand(rSQL, Global.dataBase);

            int result = annulerReservation.ExecuteNonQuery();

            annulerReservation.Cancel();

            if (result >= 1)
            {
                MessageBox.Show("Réservation annulée");
                // Remplissage de la table
                this.remplirTableReservation();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue. Veuillez recommencer.");
                return;
            }
        }

        private void remplirTableReservation()
        {
            // Nettoyage de la table
            TABLE_TrajetsReserves.Rows.Clear();
            // Remplissage de la table des réservations
            string rSQL = "SELECT R.Trajet_Id, Trajet_Date, Trajet_HeureDepart, Ville_Depart " +
            "FROM RESERVER R " +
            "JOIN TRAJET T ON T.Trajet_Id = R.Trajet_Id " +
            "WHERE R.Utilisateur_Id = " + Global.user.getId();

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            // Si pas de trajets réservés...
            if (!data.HasRows)
            {
                // Cache le bouton de réservation
                BTN_AnnulerReservation.Visible = false;
                // Ferme la commande et la requête à la base 
                this.fermetureRequete(cmd, data);
                return;
            }

            BTN_AnnulerReservation.Visible = true;
            // Remplissage de la table
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_TrajetsReserves.Rows.Add((int)dataRecord[0], (string)dataRecord[1].ToString(), (string)dataRecord[2].ToString(), (string)dataRecord[3]);
            }

            // Ferme la commande et la requête à la base 
            this.fermetureRequete(cmd, data);
        }

        private void rechercheDemandeReservation()
        {
            string rSQL =
            "SELECT COUNT(Trajet_Id) " +
            "FROM RESERVER " +
            "WHERE Trajet_Id IN ( " +
                "SELECT Trajet_Id " +
                "FROM TRAJET " +
                "WHERE Utilisateur_Id = " + Global.user.getId() +
             ") " +
             "AND accepte IS NULL";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            // Si pas de trajets réservés...
            if (!data.HasRows)
            {
                // Cache le bouton de réservation
                L_CompteurReservations.Visible = false;
                // Ferme la commande et la requête à la base 
                this.fermetureRequete(cmd, data);
            }
            data.Read();
            var dataRecord = (IDataRecord)data;
            int count = (int)dataRecord[0];
            L_CompteurReservations.Text = count.ToString();
            if (count != 0)
            {
                L_CompteurReservations.ForeColor = Color.Red;
                MessageBox.Show(String.Format("Vous avez {0} demande{1} de réservation en attente", count, (count > 1) ? "s" : ""));
            }

            this.fermetureRequete(cmd, data);
        }

        private void fermetureRequete(SqlCommand cmd, SqlDataReader data)
        {
            cmd.Cancel();
            data.Close();
        }
    }
}
