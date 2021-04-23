using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBCarpooling.Entities
{
    class Ville
    {
        private string nom;
        private string codePostal;
        private float latitude;
        private float longitude;
        private string pays;

        public Ville(string nom, string codePostal, float latitude, float longitude, string pays)
        {
            this.nom = nom;
            this.codePostal = codePostal;
            this.latitude = latitude;
            this.longitude = longitude;
            this.pays = pays;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getCodePostal()
        {
            return this.codePostal;
        }

        public float getLatitude()
        {
            return this.latitude;
        }

        public float getLongitude()
        {
            return this.longitude;
        }

        public string getPays()
        {
            return this.pays;
        }

        public void setPays(string pays)
        {
            this.pays = pays;
        }
    }
}
