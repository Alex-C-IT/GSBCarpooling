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
    public partial class FEN_GestionCars : Form
    {
        public FEN_GestionCars()
        {
            InitializeComponent();
        }

        private void FEN_GestionCars_Load(object sender, EventArgs e)
        {
            this.chargerTable();
        }

        private void chargerTable()
        {
            TABLE_Cars.Rows.Clear();

            string rSQL =
               "SELECT Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_Annee, Vehicule_Couleur, Vehicule_NbPlaces, Vehicule_societe, Vehicule_immatriculation, Carburant_Libelle, Utilisateur_Nom, Utilisateur_Prenom, TypeVehicule_Libelle " +
               "FROM VEHICULE V " +
               "JOIN CARBURANT C ON C.Carburant_Id = V.Carburant_Id " +
               "JOIN TYPE_VEHICULE TV ON TV.TypeVehicule_Id = V.TypeVehicule_Id " +
               "JOIN UTILISATEUR U ON U.Utilisateur_Id = V.Utilisateur_Id " +
               "WHERE Utilisateur_Actif = 1 AND Vehicule_Actif = 1";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;

                TABLE_Cars.Rows.Add((int)dataRecord[0], (string)dataRecord[1], (string)dataRecord[2], (int)dataRecord[3], (string)dataRecord[4], (byte)dataRecord[5], (bool)dataRecord[6], (string)dataRecord[7], (string)dataRecord[8], (string)dataRecord[9], (string)dataRecord[10], (string)dataRecord[11]);
            }
            data.Close();
        }

        private void miseAJourLigneEnCours()
        {
            int id = (int)TABLE_Cars.CurrentRow.Cells[0].Value;

            string rSQL =
               "SELECT Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_Annee, Vehicule_Couleur, Vehicule_NbPlaces, Vehicule_societe, Vehicule_immatriculation, Carburant_Libelle, Utilisateur_Nom, Utilisateur_Prenom, TypeVehicule_Libelle " +
               "FROM VEHICULE V " +
               "JOIN CARBURANT C ON C.Carburant_Id = V.Carburant_Id " +
               "JOIN TYPE_VEHICULE TV ON TV.TypeVehicule_Id = V.TypeVehicule_Id " +
               "JOIN UTILISATEUR U ON U.Utilisateur_Id = V.Utilisateur_Id " +
               "WHERE Vehicule_Id = " + id + " AND Utilisateur_Actif = 1 AND Vehicule_Actif = 1";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            if (data.Read() == false) return;

            var dataRecord = (IDataRecord)data;
            TABLE_Cars.CurrentRow.Cells[0].Value = (int)dataRecord[0];
            TABLE_Cars.CurrentRow.Cells[1].Value = (string)dataRecord[1];
            TABLE_Cars.CurrentRow.Cells[2].Value = (string)dataRecord[2];
            TABLE_Cars.CurrentRow.Cells[3].Value = (int)dataRecord[3];
            TABLE_Cars.CurrentRow.Cells[4].Value = (string)dataRecord[4];
            TABLE_Cars.CurrentRow.Cells[5].Value = (byte)dataRecord[5];
            TABLE_Cars.CurrentRow.Cells[6].Value = (bool)dataRecord[6];
            TABLE_Cars.CurrentRow.Cells[7].Value = (string)dataRecord[7];
            TABLE_Cars.CurrentRow.Cells[8].Value = (string)dataRecord[8];
            TABLE_Cars.CurrentRow.Cells[9].Value = (string)dataRecord[9];
            TABLE_Cars.CurrentRow.Cells[10].Value = (string)dataRecord[10];
            TABLE_Cars.CurrentRow.Cells[11].Value = (string)dataRecord[11];

            data.Close();
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

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Nouveau_Click(object sender, EventArgs e)
        {
            Form newCar = new FEN_Car(modeOuverture.CREATION);
            newCar.ShowDialog();

            this.chargerTable();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)TABLE_Cars.CurrentRow.Cells[0].Value;
            Form newCar = new FEN_Car(modeOuverture.MODIFICATION, id);
            newCar.ShowDialog();

            this.miseAJourLigneEnCours();
        }

        private void BTN_Disable_Click(object sender, EventArgs e)
        {
            int id = (int)TABLE_Cars.CurrentRow.Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de vouloir désactiver ce véhicule ?", "Message de confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (new VehiculeRepository()).disable(id);
                this.chargerTable();
            }
        }

        private void BTN_Actualiser_Click(object sender, EventArgs e)
        {
            this.chargerTable();
        }

        private void TABLE_Cars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)TABLE_Cars.CurrentRow.Cells[0].Value;
            Form newCar = new FEN_Car(modeOuverture.MODIFICATION, id);
            newCar.ShowDialog();

            this.miseAJourLigneEnCours();
        }
    }
}
