using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCarpooling.Repositoies;

namespace GSBCarpooling.Entities
{
    class Vehicule
    {
        private int id;
        private string marque;
        private string modele;
        private string annee;
        private string couleur;
        private byte nbPlaces;
        private bool societe;
        private string immatriculation;
        private string carburant;
        private string utilisateur;
        private byte typeVehicule;

        public Vehicule(int id, string marque, string modele, string annee, string couleur, byte nbPlaces, bool societe, string immatriculation, string carburant, string utilisateur, byte typeVehicule)
        {
            if(id != 0)
                this.id = id;
            this.marque = marque;
            this.modele = modele;
            this.annee = annee;
            this.couleur = couleur;
            this.nbPlaces = nbPlaces;
            this.societe = societe;
            this.immatriculation = immatriculation;
            this.carburant = carburant;
            this.utilisateur = utilisateur;
            this.typeVehicule = typeVehicule;
        }

        public int getId()
        {
            return this.id;
        }

        public string getMarque()
        {
            return this.marque;
        }

        public string getModele()
        {
            return this.modele;
        }

        public string getAnnee()
        {
            return this.annee;
        }

        public string getCouleur()
        {
            return this.couleur;
        }

        public byte getNbPlaces()
        {
            return this.nbPlaces;
        }

        public bool getSociete()
        {
            return this.societe;
        }

        public string getImmatriculation()
        {
            return this.immatriculation;
        }

        public string getCarburant()
        {
            return this.carburant;
        }

        public string getUtilisateur()
        {
            return this.utilisateur;
        }

        public byte getTypeVehicule()
        {
            return this.typeVehicule;
        }

        public bool ajouterVehicule()
        {
            return (new VehiculeRepository()).insert(this);
        }
        public bool modifierVehicule()
        {
            return (new VehiculeRepository()).update(this);
        }

        public bool desactiverVehicule()
        {
            return (new VehiculeRepository()).disable(this.getId());
        }
    }
}
