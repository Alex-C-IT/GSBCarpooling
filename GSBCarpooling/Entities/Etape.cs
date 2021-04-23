using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBCarpooling.Entities
{
    class Etape
    {
        private int trajetId;
        private int etapeId;
        //DateTime dateArrivee;
        //DateTime heureArrivee;
        byte ordre;
        string ville;
        string codePostal;

        public Etape(int trajetId, int etapeId, string ville, string codePostal, byte ordre)
        {
            if (trajetId != 0)
                this.trajetId = trajetId;

            if (etapeId != 0)
                this.etapeId = etapeId;

            this.ville = ville;
            this.codePostal = codePostal;
            this.ordre = ordre;
        }

        public int getTrajetId()
        {
            return this.trajetId;
        }

        public int getEtapeId()
        {
            return this.etapeId;
        }

        /*public DateTime getDateArrivee()
        {
            return this.dateArrivee;
        }

        public DateTime getHeureArrivee()
        {
            return this.heureArrivee;
        }*/

        public byte getOrdre()
        {
            return this.ordre;
        }

        public string getVille()
        {
            return this.ville;
        }

        public string getCodePostal()
        {
            return this.codePostal;
        }





    }
}
