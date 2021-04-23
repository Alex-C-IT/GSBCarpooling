using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCarpooling.Repositoies;

namespace GSBCarpooling.Entities
{
    class Trajet
    {
        private int id;
        private DateTime date;
        private DateTime heure;
        private string commentaire;
        private byte nbPassagers;
        private int vehicule;
        private int utilisateur;
        private string villeDepart;
        private List<Etape> etapes;

        public Trajet(int id, DateTime date, DateTime heure, string commentaire, byte nbPassagers, int vehicule, int utilisateur, string villeDepart)
        {
            if (id != 0)
                this.id = id;

            this.date = date;
            this.heure = heure;
            this.commentaire = commentaire;
            this.nbPassagers = nbPassagers;
            this.vehicule = vehicule;
            this.utilisateur = utilisateur;
            this.villeDepart = villeDepart;

            this.etapes = new List<Etape>();
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public DateTime getHeure()
        {
            return this.heure;
        }

        public string getCommentaire()
        {
            return this.commentaire;
        }

        public byte getNbPassagers()
        {
            return this.nbPassagers;
        }

        public int getVehicule()
        {
            return this.vehicule;
        }

        public int getUtilisateur()
        {
            return this.utilisateur;
        }
        public string getVilleDepart()
        {
            return this.villeDepart;
        }

        public List<Etape> getListeEtapes()
        {
            return this.etapes;
        }

        public void setListeEtapes(List<Etape> etapes)
        {
            this.etapes = etapes;
        }

        public void ajouterEtape(Etape etape)
        {
            this.etapes.Add(etape);
        }

        public void supprimerEtape(Etape etape)
        {
            this.etapes.Remove(etape);
        }
           
        public bool ajouterTrajet()
        {
            return (new TrajetRepository()).insert(this);
        }

        public bool modifierTrajet()
        {
            return (new TrajetRepository()).update(this);
        }



    }
}
