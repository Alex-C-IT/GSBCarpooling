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
    public partial class FEN_Admin : Form
    {
        public FEN_Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L_Welcome.Text += " " + Global.user.getPseudonyme() + " (Compte Administrateur)";
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

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form gestionUser = new FEN_GestionUsers();
            gestionUser.ShowDialog();
        }

        private void BTN_GestionCars_Click(object sender, EventArgs e)
        {
            Form gestionCars = new FEN_GestionCars();
            gestionCars.ShowDialog();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quitter l'espace d'administration ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BTN_GestionTrajets_Click(object sender, EventArgs e)
        {
            Form gestionTrajet = new FEN_GestionTrajets();
            gestionTrajet.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.remplirTableVoitureSelonAnnee(Convert.ToInt16(CBX_Annees.Text));
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void remplirTableVoitureSelonAnnee(int annee)
        {
            TABLE_UtilisationVehicules.Rows.Clear();

            string rSql = "SELECT T.Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_immatriculation, COUNT(T.Vehicule_Id) " +
                "FROM VEHICULE V " +
                "JOIN TRAJET T ON T.Vehicule_Id = V.Vehicule_Id " +
                "WHERE YEAR(Trajet_Date) = " + annee + " " +
                "GROUP BY T.Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_immatriculation";

            SqlCommand cmd = new SqlCommand(rSql, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                TABLE_UtilisationVehicules.Rows.Add((string)dataRecord[1], (string)dataRecord[2], (string)dataRecord[3], (int)dataRecord[4]);
            }
            this.fermetureRequete(cmd, data);
        }

        private void fermetureRequete(SqlCommand cmd = null, SqlDataReader data = null)
        {
            if(data != null) data.Close();
            if(cmd != null) cmd.Cancel();
        }
    }
}
