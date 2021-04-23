using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBCarpooling.Entities
{
    class Carburant
    {
        private string id;
        private string libelle;

        public Carburant(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string getId()
        {
            return this.id;
        }

        public string getLibelle()
        {
            return this.libelle;
        }
    }
}
