using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBCarpooling.Entities
{
    class TypeVehicule
    {
        private int id;
        private string libelle;

        public TypeVehicule(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int getId()
        {
            return this.id;
        }

        public string getLibelle()
        {
            return this.libelle;
        }
    }
}
