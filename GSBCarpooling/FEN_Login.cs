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
using System.Diagnostics;
using System.Security.Cryptography;
using GSBCarpooling.Entities;

namespace GSBCarpooling
{
    public partial class FEN_Login : Form
    {
        public FEN_Login()
        {
            InitializeComponent();
            L_Erreur.Visible = false;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            //Si champ nom d'utilisateur est vide...
            if(SAI_Username.Text == "")
            {
                L_Erreur.Visible = true;
                L_Erreur.Text = "Veuillez saisir un nom d'utilisateur...";
                return;
            }
            //Si champ mot de passe est vide...
            if (SAI_Password.Text == "")
            {
                L_Erreur.Visible = true;
                L_Erreur.Text = "Veuillez saisir votre mot de passe...";
                return;
            }

            //Connexion à la base de données 
            SqlConnection db = new SqlConnection(Connection.conString);
            try
            {
                db.Open();
            }
            catch (SqlException)
            {
                L_Erreur.Visible = true;
                L_Erreur.Text = "Connexion au serveur impossible...";
                return;
            }

            // Vérifie le statut de la base de données
            if (db.State == System.Data.ConnectionState.Open)
            {
                // Sauvegarde la connexion à la base de données dans une global au système
                Global.dataBase = db;

                // Récupère les informations saisies
                string username = SAI_Username.Text.ToString();
                string password = Security.Sha256Hash(SAI_Password.Text.ToString());

                // Vérifie si le compte de l'utilisateur est actif
                string rSQL = "SELECT * FROM UTILISATEUR WHERE Utilisateur_Pseudonyme = @username AND Utilisateur_HashPassword = @password AND Utilisateur_Actif = 0";
                SqlCommand cmd = new SqlCommand(rSQL, db);
                cmd.CommandText = rSQL;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader data = cmd.ExecuteReader();

                // S'il y a des données alors l'utilisateur a été trouvé comme utilisateur suspendu...
                if (data.HasRows)
                {
                    L_Erreur.Visible = true;
                    L_Erreur.Text = "Accès refusé...";
                    MessageBox.Show("Accès refusé ! Votre compte a été suspendu... Veuillez contacter votre administrateur système.");
                    this.fermetureRequete(cmd, data);
                    return;
                }
                this.fermetureRequete(cmd, data);

                // Recherche l'utilisateur avec le nom d'utilisateur et le mot de passe saisi.
                rSQL = "SELECT * FROM UTILISATEUR WHERE Utilisateur_Pseudonyme = @username AND Utilisateur_HashPassword = @password AND Utilisateur_Actif = 1";
                cmd = new SqlCommand(rSQL, db);
                cmd.CommandText = rSQL;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                data = cmd.ExecuteReader();

                // Si pas de données, l'utilisateur n'existe pas...
                if (!data.HasRows) {
                    L_Erreur.Visible = true;
                    L_Erreur.Text = "Le nom d'utilisateur et/ou le mot de passe est incorrect...";
                    this.fermetureRequete(cmd, data);
                    return;
                }
                
                
                int i = 0;
                while(data.Read()) {
                    // Vérifie qu'il n'y ait pas un doublon de compte.
                    // Si i > 2 alors i comptes trouvés. Erreur et arrêt de l'opération
                    if (i > 0) {
                        L_Erreur.Visible = true;
                        L_Erreur.Text = "Veuillez contacter l'administrateur système. (Code erreur : 0001)";
                        this.fermetureRequete(cmd, data);
                        return;
                    }

                    // Lecture des données utilisateur
                    var dataRecord = (IDataRecord)data;
                    // Stock les informations de l'utilisateur dans une global au système
                    Global.user = new Utilisateur((int)dataRecord[0], (string)dataRecord[1], (string)dataRecord[2], (string)dataRecord[4], (DateTime)dataRecord[6], (string)dataRecord[7], (string)dataRecord[13], (string)dataRecord[14], (string)dataRecord[8], (string)dataRecord[9], (string)dataRecord[10], (DateTime)dataRecord[11], (string)dataRecord[15], (bool)dataRecord[12]);
                    i++;
                }

                // L'utilisateur est vérifié. Log OK
                Global.logOK = true;

                this.fermetureRequete(cmd, data);

                // Charge les données importantes au programme en cache pour travailler en mémoire
                Cache.chargerCacheVilles();
                Cache.chargerCachePays();
                Cache.chargerCacheTypeVehicule();
                Cache.chargerCacheCarburant();

                // Tout est OK (Utilisateur et mot de passe OK && pas de doublon Ok : Connexion)
                // Si utilisateur administrateur alors il lui est proposé de se rendre sur l'espace d'administration
                if (Global.user.getTypeUtilisateur() == "ADMIN")
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous accéder à l'administration ?", "Message de confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form FEN_Admin = new FEN_Admin();
                        this.Hide();
                        FEN_Admin.ShowDialog();
                        Close();
                    }
                    Close();
                }
                else
                {
                    this.Hide();
                    Close();
                }
            }
            else
            {
                L_Erreur.Visible = true;
                L_Erreur.Text = "Erreur de connexion au serveur.";
            }    
        }

        private void CBX_Mdp_CheckedChanged(object sender, EventArgs e)
        {
            if(!CBX_Mdp.Checked)
                SAI_Password.UseSystemPasswordChar = true;
            else
                SAI_Password.UseSystemPasswordChar = false;
        }

        private void fermetureRequete(SqlCommand cmd, SqlDataReader data)
        {
            cmd.Cancel();
            data.Close();
        }
    }
}
