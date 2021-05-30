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
    public partial class FEN_ChangerMotDePasse : Form
    {
        public FEN_ChangerMotDePasse()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FEN_ChangerMotDePasse_Load(object sender, EventArgs e)
        {
            SAI_AncienMdp.UseSystemPasswordChar             = true;
            SAI_NouveauMdp.UseSystemPasswordChar            = true;
            SAI_ConfirmerNouveauMdp.UseSystemPasswordChar   = true;
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            // Vérifie si les mots de passes sont identiques
            if(SAI_NouveauMdp.Text != SAI_ConfirmerNouveauMdp.Text)
            {
                MessageBox.Show("Les mots de passe ne sont pas identiques... Veuillez recommencer.");
                return;
            }

            // Vérifie si le mot de passe actuel est correct
            string rSql = "SELECT Utilisateur_HashPassword FROM UTILISATEUR WHERE Utilisateur_Id = " + Global.user.getId();
            SqlCommand cmd = new SqlCommand(rSql, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            if (!data.HasRows) {
                MessageBox.Show("L'utilisateur est introuvable...");
                return;
            }

            data.Read();
            var dataRecord = (IDataRecord)data;

            if((string)dataRecord[0] != Security.Sha256Hash(SAI_AncienMdp.Text)) {
                MessageBox.Show("L'ancien mot de passe saisi est incorrect.");
                return;
            }

            this.fermetureRequete(cmd, data);

            Global.user.setHashpassword(Security.Sha256Hash(SAI_NouveauMdp.Text));

            if (Global.user.changerMotDePasse() == true)
            {
                MessageBox.Show("Mot de passe changé avec succès.");
                Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue lors de la modification du mot de passe. Veuillez recommencer.");
                return;
            }
        }
        private void fermetureRequete(SqlCommand cmd, SqlDataReader data)
        {
            cmd.Cancel();
            data.Close();
        }
    }
}
