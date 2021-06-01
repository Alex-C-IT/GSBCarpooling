using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCarpooling.Entities;
using GSBCarpooling.Repositoies;
using System.Data.SqlClient;

namespace GSBCarpooling
{
    public partial class FEN_User : Form
    {
        private modeOuverture mode;
        private int? id;

        public FEN_User(modeOuverture mode = modeOuverture.CREATION, int? id = null)
        {
            this.mode = mode;
            this.id = id;

            InitializeComponent();
        }

        private void FEN_User_Load(object sender, EventArgs e)
        {
            BTN_ChangerMdp.Visible = false;

            // Si mode ouverture = MODIFICATION 
            if(mode == modeOuverture.MODIFICATION) {

                this.Text = "Modification d'un utilisateur";

                // Cacher champs mot de passe 
                L_Mdp.Visible = false;
                SAI_Mdp.Visible = false;
                L_ConfirmerMdp.Visible = false;
                SAI_ConfirmMdp.Visible = false;

                BTN_ChangerMdp.Visible = true;

                this.chargerChamps();

                if (Global.user.getTypeUtilisateur() != "ADMIN")
                {
                    this.Text = "Informations personnelles utilisateur";
                    SAI_Nom.Enabled = false;
                    SAI_Prenom.Enabled = false;
                    SAI_Pseudonyme.Enabled = false;
                    DATE_DateNaissance.Enabled = false;
                    CBX_Sexe.Enabled = false;
                    SAI_Mail.Enabled = false;
                    SAI_Mobile.Enabled = false;
                    SAI_Adresse.Enabled = false;
                    CBX_Ville.Enabled = false;
                    SAI_CodePostal.Enabled = false;
                    CBX_Pays.Enabled = false;
                    CBX_TypeUser.Enabled = false;
                    CBX_TypeUser.Visible = false;
                    L_TypeUser.Visible = false;
                    BTN_Valider.Visible = false;
                }
            }

            // Combo sexe
            CBX_Sexe.Items.Add("Homme");
            CBX_Sexe.Items.Add("Femme");

            // Combo villes
            foreach(Ville ville in Cache.villes) {
                CBX_Ville.Items.Add(ville.getNom());
            }

            // Combo pays
            foreach (Pays pays in Cache.pays)
            {
                CBX_Pays.Items.Add(pays.getLibelle());
            }

            // Combo type utilisateur
            CBX_TypeUser.Items.Add("ADMIN");
            CBX_TypeUser.Items.Add("USER");


        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            // Validation du formulaire
            string nom = SAI_Nom.Text;
            string prenom = SAI_Prenom.Text;
            string pseudo = SAI_Pseudonyme.Text;
            DateTime dateDeNaissance = DATE_DateNaissance.Value;
            string sexe = CBX_Sexe.Text;
            string adresse = SAI_Adresse.Text;
            string ville = CBX_Ville.Text;
            string codePostal = SAI_CodePostal.Text;
            string mail = SAI_Mail.Text;
            string mobile = SAI_Mobile.Text;
            string typeUser = CBX_TypeUser.Text;


            if(this.mode == modeOuverture.CREATION) {

                // Vérifie que les mots de passe soient identiques
                if(SAI_Mdp.Text != SAI_ConfirmMdp.Text) {
                    MessageBox.Show("Les mots de passe ne sont pas identiques. Veuillez réessayer.");
                    return;
                }
                string password = Security.Sha256Hash(SAI_Mdp.Text);

                // Initialisation de l'utilisateur
                Utilisateur user = new Utilisateur(0, nom, prenom, pseudo, dateDeNaissance, adresse, ville, codePostal, mail, mobile, sexe, DateTime.Today, typeUser, false, password);

                // Ajout de l'utilisateur 
                if (user.ajouterUtilisateur() != true) {
                    MessageBox.Show("Une erreur est survenue. Veuillez réessayer !");
                } else {
                    MessageBox.Show("L'utilisateur " + user.getNom() + " " + user.getPrenom() + " a été ajouté !");
                    Close();
                }
            } else {
                // Initialisation de l'utilisateur
                Utilisateur user = new Utilisateur((int)this.id, nom, prenom, pseudo, dateDeNaissance, adresse, ville, codePostal, mail, mobile, sexe, DateTime.Today, typeUser, false);

                // Modification de l'utilisateur 
                if (user.modifierUtilisateur() != true)
                {
                    MessageBox.Show("Une erreur est survenue. Veuillez réessayer !");
                }
                else
                {
                    MessageBox.Show("L'utilisateur " + user.getNom() + " " + user.getPrenom() + " a bien été modifié !");
                    Close();
                }
            }

        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chargerChamps()
        {
            string rSQL =
           "SELECT Utilisateur_Nom, Utilisateur_Prenom, Utilisateur_Pseudonyme, Utilisateur_DateNaissance, Utilisateur_Sexe, Utilisateur_Email, Utilisateur_TelMobile, Utilisateur_Rue, U.Ville_Nom, U.Ville_CodePostal, Pays_Libelle, TypeUtilisateur_Id " +
           "FROM UTILISATEUR U " +
           "JOIN VILLE V ON V.Ville_Nom = U.Ville_Nom " +
           "JOIN PAYS P ON P.Pays_Id = V.Pays_Id " + 
           "WHERE Utilisateur_Id = " + this.id;

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            
            if(data.Read() == false) {
                MessageBox.Show("Une erreur est survenue lors du chargement des données utilisateur...");
                Close();
                return;
            }

            var dataRecord = (IDataRecord)data;

            SAI_Nom.Text = (string)dataRecord[0];
            SAI_Prenom.Text = (string)dataRecord[1];
            SAI_Pseudonyme.Text = (string)dataRecord[2];
            DATE_DateNaissance.Value = (DateTime)dataRecord[3];
            CBX_Sexe.Text = (string)dataRecord[4];
            SAI_Mail.Text = (string)dataRecord[5];
            SAI_Mobile.Text = (string)dataRecord[6];
            SAI_Adresse.Text = (string)dataRecord[7];
            CBX_Ville.Text = (string)dataRecord[8];
            SAI_CodePostal.Text = (string)dataRecord[9];
            CBX_Pays.Text = (string)dataRecord[10];
            CBX_TypeUser.Text = (string)dataRecord[11];

            data.Close();
        }

        private void BTN_ChangerMdp_Click(object sender, EventArgs e)
        {
            Form changerMdp = new FEN_ChangerMotDePasse();
            changerMdp.ShowDialog();
        }
    }
}
