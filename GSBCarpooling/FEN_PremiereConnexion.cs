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
    public partial class FEN_PremiereConnexion : Form
    {
        public FEN_PremiereConnexion()
        {
            InitializeComponent();
        }

        private void FEN_PremiereConnexion_Load(object sender, EventArgs e)
        {
            SAI_Password.UseSystemPasswordChar = true;
            SAI_ConfirmPassword.UseSystemPasswordChar = true;
        }

        private void BTN_Confirmer_Click(object sender, EventArgs e)
        {
            string password = SAI_Password.Text;
            string confirmedPassworrd = SAI_ConfirmPassword.Text;

            if (password != confirmedPassworrd) {
                MessageBox.Show("Les mot de passes ne sont pas identiques. Veuillez recommencer.");
                return;
            }

            if (this.changePassword(password))
            {
                MessageBox.Show("Mot de passe changé avec succès");
                Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue.");
                return;
            }
        }

        private bool changePassword(string password)
        {
            string passwordSHA256 = Security.Sha256Hash(password);

            string rSQL = "UPDATE UTILISATEUR SET Utilisateur_HashPassword = '" + passwordSHA256 + "', Utilisateur_PremiereConnexion = 0 WHERE Utilisateur_Id = " + Global.user.getId();
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);

            if (cmd.ExecuteNonQuery() < 1) {
                cmd.Cancel();
                return false;
            }

            cmd.Cancel();
            return true;
        }

    }
}
