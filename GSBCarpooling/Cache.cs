using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCarpooling.Entities;
using System.Data;
using System.Data.SqlClient;

namespace GSBCarpooling
{
    class Cache
    {
        public static List<Ville> villes = new List<Ville>();
        public static List<Pays> pays = new List<Pays>();
        public static List<TypeVehicule> typeVehicule = new List<TypeVehicule>();
        public static List<Carburant> carburant = new List<Carburant>();

        public static void chargerCacheVilles()
        {
            string rSQL = "SELECT * FROM VILLE";
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                Cache.villes.Add(new Ville((string)dataRecord[0], (string)dataRecord[1], (float)dataRecord[2], (float)dataRecord[3], (string)dataRecord[4]));
            }
            data.Close();
            cmd.Cancel();
        }

        public static void chargerCachePays()
        {
            string rSQL = "SELECT * FROM PAYS";
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                Cache.pays.Add(new Pays((string)dataRecord[0], (string)dataRecord[1]));
            }
            data.Close();
            cmd.Cancel();
        }

        public static void chargerCacheTypeVehicule()
        {
            string rSQL = "SELECT TypeVehicule_Id, TypeVehicule_Libelle FROM TYPE_VEHICULE";
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                Cache.typeVehicule.Add(new TypeVehicule((byte)dataRecord[0], (string)dataRecord[1]));
            }
            data.Close();
            cmd.Cancel();
        }

        public static void chargerCacheCarburant()
        {
            string rSQL = "SELECT * FROM CARBURANT";
            SqlCommand cmd = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                var dataRecord = (IDataRecord)data;
                Cache.carburant.Add(new Carburant((string)dataRecord[0], (string)dataRecord[1]));
            }
            data.Close();
            cmd.Cancel();
        }
    }
}
