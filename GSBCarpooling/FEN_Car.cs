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
using GSBCarpooling.Entities;

namespace GSBCarpooling
{
    public partial class FEN_Car : Form
    {
        private modeOuverture mode;
        private int? id;

        public FEN_Car(modeOuverture mode = modeOuverture.CREATION, int? id = null)
        {
            this.mode = mode;
            this.id = id;

            InitializeComponent();
        }

        private void FEN_Car_Load(object sender, EventArgs e)
        {
            // Si mode ouverture = MODIFICATION 
            if (mode == modeOuverture.MODIFICATION)
            {
                this.Text = "Modification d'un véhicule";
                this.chargerChamps();
            }

            // Combo type véhicule
            foreach (TypeVehicule ty in Cache.typeVehicule)
            {
                CB_TypeVehicule.Items.Add(ty.getId());
            }

            // Combo carburant
            foreach (Carburant c in Cache.carburant)
            {
                CB_Carburant.Items.Add(c.getId());
            }
        }
        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {
            string marque = SAI_Marque.Text;
            string modele = SAI_Modele.Text;
            string annee = SAI_Annee.Text;
            string couleur = SAI_Couleur.Text;
            byte nbPlaces = byte.Parse(SAI_nbPlaces.Text);
            bool societe;
            if (CBX_Societe.Checked)
                societe = true;
            else
                societe = false;
            string immatriculation = SAI_immatriculation.Text;
            string carburant = CB_Carburant.Text;
            string utilisateur = SAI_userId.Text;
            byte typeVehicule = byte.Parse(CB_TypeVehicule.Text);

            if (this.mode == modeOuverture.CREATION)
            {
                // Initialisation du véhicule
                Vehicule car = new Vehicule(0, marque, modele, annee, couleur, nbPlaces, societe, immatriculation, carburant, utilisateur, typeVehicule);

                // Ajout de l'utilisateur 
                if (car.ajouterVehicule() != true)
                {
                    MessageBox.Show("Une erreur est survenue. Veuillez réessayer !");
                }
                else
                {
                    MessageBox.Show("Le véhicule a bien été ajouté !");
                    Close();
                }
            }
            else
            {
                // Initialisation de l'utilisateur
                Vehicule car = new Vehicule((int)this.id, marque, modele, annee, couleur, nbPlaces, societe, immatriculation, carburant, utilisateur, typeVehicule);

                // Modification de l'utilisateur 
                if (car.modifierVehicule() != true)
                {
                    MessageBox.Show("Une erreur est survenue. Veuillez réessayer !");
                }
                else
                {
                    MessageBox.Show("Le véhicule #"+ car.getId() +" a bien été modifié !");
                    Close();
                }
            }
        }

        private void chargerChamps()
        {
            string rSQL =
                "SELECT Vehicule_Marque, Vehicule_Modele, Vehicule_Annee, Vehicule_Couleur, Vehicule_NbPlaces, Vehicule_societe, Vehicule_immatriculation, Carburant_Id, Utilisateur_Id, TypeVehicule_Id " +
                "FROM VEHICULE " +
                "WHERE Vehicule_Id = " + this.id;

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == false)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des données du véhicule...");
                Close();
                return;
            }

            var dataRecord = (IDataRecord)data;

            SAI_Marque.Text = (string)dataRecord[0];
            SAI_Modele.Text = (string)dataRecord[1];
            SAI_Annee.Text = dataRecord[2].ToString();
            SAI_Couleur.Text = (string)dataRecord[3];
            SAI_nbPlaces.Text = dataRecord[4].ToString();
            CBX_Societe.Checked = (bool)dataRecord[5];
            SAI_immatriculation.Text = (string)dataRecord[6];
            CB_Carburant.Text = (string)dataRecord[7];
            SAI_userId.Text = dataRecord[8].ToString();
            CB_TypeVehicule.Text = dataRecord[9].ToString();

            data.Close();
        }
    }
}
