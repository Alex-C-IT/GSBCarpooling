using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
