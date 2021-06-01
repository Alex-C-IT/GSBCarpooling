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
using GSBCarpooling.Repositoies;

namespace GSBCarpooling
{
    public partial class FEN_ProposerTrajet : Form
    {
        private byte i;
        Trajet trajet;
        Etape depart;
        Etape arrivee;
        List<Etape> listeEtapes;
        List<Vehicule> listeVehicule;

        private modeOuverture mode;
        private int? id;

        public FEN_ProposerTrajet(modeOuverture mode = modeOuverture.CREATION, int? id = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.id = id;
            this.listeEtapes = new List<Etape>();
            this.listeVehicule = new List<Vehicule>();
            this.i = 2;
        }

        private void FEN_ProposerTrajet_Load(object sender, EventArgs e)
        {
            // Si mode ouverture = MODIFICATION 
            if (mode == modeOuverture.MODIFICATION)
            {

                this.Text = "Modification d'un trajet";
                this.chargerChamps();
            }

                L_Info.Visible = false;

            // Paramètrage listBox
            LB_Etapes.SelectionMode = SelectionMode.One;

            // Paramètrage des dateTimePickers
            dateTimePicker_DateDepart.MinDate = DateTime.Today;
            dateTimePicker_HeureDepart.CustomFormat = "HH:mm";
            dateTimePicker_HeureDepart.Format = DateTimePickerFormat.Custom;

            // Paramètrage des combos
            C_VilleDepart.AutoCompleteMode = AutoCompleteMode.Append;
            C_VilleDepart.AutoCompleteSource = AutoCompleteSource.ListItems;

            C_VilleArrivee.AutoCompleteMode = AutoCompleteMode.Append;
            C_VilleArrivee.AutoCompleteSource = AutoCompleteSource.ListItems;

            C_Etape.AutoCompleteMode = AutoCompleteMode.Append;
            C_Etape.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Remplissage des combos de villes
            foreach (Ville ville in Cache.villes)
            {
                C_VilleDepart.Items.Add(ville.getNom());
                C_VilleArrivee.Items.Add(ville.getNom());
                C_Etape.Items.Add(ville.getNom());
            }

            // Recherche les véhicules de l'utilisateur et les ajoute à la combo
            string rSQL =
                "SELECT Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_NbPlaces " +
                "FROM VEHICULE " +
                "WHERE Utilisateur_Id = " + Global.user.getId();

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                C_Vehicuke.Items.Add((int)dataRecord[0] + " " + (string)dataRecord[1] + " " + (string)dataRecord[2] + " " + (byte)dataRecord[3] + " p");
            }

            data.Close();
            cmd.Cancel();

            // Nombre de passagers max
            numericUpDown_nbPassagers.Maximum = 3;

        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Ville rechercheVilleEtape(string nomVille)
        {
            foreach (Ville v in Cache.villes)
                if (v.getNom() == nomVille)
                    return v;

            return null;
        }

        private Etape rechercheEtapeDansListe(string nomVille)
        {
            foreach (Etape etape in listeEtapes)
                if (etape.getVille() == nomVille)
                    return etape;

            return null;
        }

        private void BTN_Etape_Click(object sender, EventArgs e)
        {
            //Vérifie si l'étape est deja présente ou si c'est une ville de départ ou d'arrivée et si c'est une ville valide
            if ((!LB_Etapes.Items.Contains(C_Etape.Text)) && (C_VilleDepart.Text != C_Etape.Text) && (C_VilleArrivee.Text != C_Etape.Text) && C_Etape.Items.Contains(C_Etape.Text) != false)
            {
                // Ajoute l'item dans la ListeBox.
                LB_Etapes.Items.Add(C_Etape.Text);
                // Recherche la ville étape dans la List des ville étape
                Ville v = rechercheVilleEtape(C_Etape.Text);
                //Si v != null alors étape trouvée.
                if (v != null)
                {
                    // Création de l'étape
                    Etape villeEtape = new Etape(0, 0, v.getNom(), v.getCodePostal(), this.i);
                    // Ajout dans la liste
                    this.listeEtapes.Add(villeEtape);
                    // Mise à jour de l'ordre de la ville d'arrivée
                    Etape lastEtape = listeEtapes[listeEtapes.Count - 2];
                    listeEtapes.Remove(lastEtape);
                    this.arrivee = new Etape(0, 0, lastEtape.getVille(), lastEtape.getCodePostal(), (byte)(lastEtape.getOrdre() + 1));
                    listeEtapes.Add(this.arrivee);

                    this.i++;
                }
            }
        }

        private void BTN_SupprimerEtape_Click(object sender, EventArgs e)
        {
            // Supprime la ville de la liste des étapes
            // Recherche la ville étape dans la List des ville étape
            Etape etape = rechercheEtapeDansListe(LB_Etapes.SelectedItem.ToString());
            if (etape != null)
                listeEtapes.Remove(etape);

            LB_Etapes.Items.Remove(LB_Etapes.SelectedItem);

            // Mise à jour de l'ordre de la ville d'arrivée
            Etape lastEtape = listeEtapes[listeEtapes.Count - 1];
            listeEtapes.Remove(lastEtape);
            this.arrivee = new Etape(0, 0, lastEtape.getVille(), lastEtape.getCodePostal(), (byte)(lastEtape.getOrdre() - 1));
            listeEtapes.Add(this.arrivee);

            this.i--;
        }

        private void BTN_Valider_Click(object sender, EventArgs e)
        {

            // Vérifie que la destination de départ et d'arrivée ne soient pas identique
            if (C_VilleDepart.Text == C_VilleArrivee.Text)
            {
                L_Info.Text = "Les villes de départ et d'arrivée sont identiques.";
                return;
            }

            // Vérifie que la ville de départ ou d'arrivée ne soient pas dans la liste des étapes
            if((LB_Etapes.Items.Contains(C_VilleDepart.Text) == true) || (LB_Etapes.Items.Contains(C_VilleArrivee.Text) == true))
            {
                MessageBox.Show("Les villes de départ et d'arrivée ne peuvent pas être ville étape.");
                return;
            }

            // Vérifie si une réservation existe à cette date
            if (this.reservationExiste(dateTimePicker_DateDepart.Value))
            {
                MessageBox.Show("Impossible de proposer un trajet car vous avez déjà un trajet réservé à cette date...");
                return;
            }

            // Ajout du trajet dans la base de données
            string[] idVehicule = C_Vehicuke.Text.Split(' ');
            if (this.mode == modeOuverture.CREATION) {
                try {
                    this.trajet = new Entities.Trajet(0, dateTimePicker_DateDepart.Value, dateTimePicker_HeureDepart.Value, RTB_commentaire.Text, byte.Parse(numericUpDown_nbPassagers.Text), int.Parse(idVehicule[0]), Global.user.getId(), C_VilleDepart.Text);
                } catch (FormatException) { MessageBox.Show("Erreur de saisie. Veuillez recommencer"); return; }
                // Ajout les étpaes au trajet
                this.trajet.setListeEtapes(listeEtapes);
                if (this.trajet.ajouterTrajet() == true) {
                    MessageBox.Show("Trajet ajouté");
                    Close();
                    return;
                }
            } else {
                // Ajout du trajet dans la base de données
                try {
                    this.trajet = new Entities.Trajet(this.trajet.getId(), dateTimePicker_DateDepart.Value, dateTimePicker_HeureDepart.Value, RTB_commentaire.Text, byte.Parse(numericUpDown_nbPassagers.Text), int.Parse(idVehicule[0]), Global.user.getId(), C_VilleDepart.Text);
                }
                catch (FormatException) { MessageBox.Show("Erreur de saisie. Veuillez recommencer"); return; }
                // Ajout les étpaes au trajet
                this.trajet.setListeEtapes(listeEtapes);
                if (this.trajet.modifierTrajet() == true) {
                    MessageBox.Show("Trajet modifié");
                    Close();
                    return;
                }
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            int caractRestants = 250 - RTB_commentaire.Text.Length;

            if (caractRestants < 0) return;

            if (L_commentaire.Text.Length >= 1)
                L_commentaire.Text = "Commentaire (" + caractRestants + " restants)";
            else
                L_commentaire.Text = "Commentaire (250 caractères max)";
        }

        private void C_Vehicuke_TextChanged(object sender, EventArgs e)
        {
            string[] split = C_Vehicuke.Text.Split(' ');

            numericUpDown_nbPassagers.Maximum = int.Parse(split[3]) - 1;
        }

        private void C_VilleDepart_TextChanged(object sender, EventArgs e)
        {
            Ville v = rechercheVilleEtape(C_VilleDepart.Text);
            if (v != null) {
                listeEtapes.Remove(this.depart);
                this.depart = new Etape(0, 0, v.getNom(), v.getCodePostal(), 1);
                listeEtapes.Add(this.depart);
            }

        }

        private void C_VilleArrivee_TextChanged(object sender, EventArgs e)
        {
            Ville v = rechercheVilleEtape(C_VilleArrivee.Text);
            if(v != null) {
                listeEtapes.Remove(this.arrivee);
                this.arrivee = new Etape(0, 0, v.getNom(), v.getCodePostal(), (byte)(listeEtapes.Count + 1));
                listeEtapes.Add(this.arrivee);
            }

        }

        private void chargerChamps()
        {
            string rSQL = "SELECT Trajet_Id, Trajet_Date, Trajet_HeureDepart, Trajet_Commentaire, Trajet_NbPassagers, T.Vehicule_Id, Vehicule_Marque, Vehicule_Modele, Vehicule_NbPlaces, T.Utilisateur_Id, T.Ville_Depart " +
                "FROM TRAJET T " +
                "JOIN VEHICULE V ON V.Vehicule_Id = T.Vehicule_Id " +
                "WHERE Trajet_Id = "+ this.id;
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == false) {
                MessageBox.Show("Une erreur est survenue lors du chargement des données du trajet...");
                Close();
                return;
            }

            var dataRecord = (IDataRecord)data;

            // Remplissage des champs
            dateTimePicker_DateDepart.Value = (DateTime)dataRecord[1];
            //dateTimePicker_HeureDepart.Value = (DateTime)dataRecord[2];
            C_Vehicuke.Text = ((int)dataRecord[5] + " " + (string)dataRecord[6] + " " + (string)dataRecord[7] + " " + (byte)dataRecord[8] + " p");
            numericUpDown_nbPassagers.Value = (byte)dataRecord[4];
            RTB_commentaire.Text = (string)dataRecord[3];
            // Création du trajet
            this.trajet = new Trajet((int)dataRecord[0], (DateTime)dataRecord[1], DateTime.Today, (string)dataRecord[3], (byte)dataRecord[4], (int)dataRecord[5], (int)dataRecord[9], (string)dataRecord[10]);
            data.Close();

            rSQL = "SELECT Trajet_Id, Etape_Id, ordre, Ville_Nom, Ville_CodePostal " +
            "FROM ETAPE " +
            "WHERE Trajet_Id = " + this.id + 
            " ORDER BY ordre ASC";
            cmd = new SqlCommand(rSQL, Global.dataBase);
            data = cmd.ExecuteReader();
            if (data.Read() == false) {
                MessageBox.Show("Une erreur est survenue lors du chargement des données du trajet...");
                Close();
                return;
            }
            do
            {
                dataRecord = (IDataRecord)data;

                if ((int)dataRecord[2] == 1)
                {
                    this.depart = new Etape((int)dataRecord[0], (byte)dataRecord[1], (string)dataRecord[3], (string)dataRecord[4], (byte)(int)dataRecord[2]);
                    this.arrivee = new Etape((int)dataRecord[0], (byte)dataRecord[1], (string)dataRecord[3], (string)dataRecord[4], (byte)(int)dataRecord[2]);
                    continue;
                }
                if ((int)dataRecord[2] > this.arrivee.getOrdre())
                {
                    if ((int)dataRecord[2] - 1 != 1)
                    {
                        listeEtapes.Add(this.arrivee);
                        LB_Etapes.Items.Add(this.arrivee.getVille().ToString());
                    }
                    this.i++;
                    this.arrivee = new Etape((int)dataRecord[0], (byte)dataRecord[1], (string)dataRecord[3], (string)dataRecord[4], (byte)(int)dataRecord[2]);
                    continue;
                }
            } while (data.Read());
            C_VilleDepart.Text = this.depart.getVille();
            C_VilleArrivee.Text = this.arrivee.getVille();
            data.Close();

        }

        private bool reservationExiste(DateTime dateTrajet)
        {
            string rSQL = "SELECT R.* " +
                "FROM RESERVER R " +
                "JOIN TRAJET T ON T.Trajet_Id = R.Trajet_Id " +
                "WHERE T.Trajet_Date = '" + dateTrajet + "'";

            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();

            // S'il y a un resultat
            if (data.HasRows)
            {
                cmd.Cancel();
                data.Close();
                return true;
            }

            cmd.Cancel();
            data.Close();
            return false;
        }


    }
}
