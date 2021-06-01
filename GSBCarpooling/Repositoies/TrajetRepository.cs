using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCarpooling.Entities;
using System.Data.SqlClient;
using System.Data;

namespace GSBCarpooling.Repositoies
{
    class TrajetRepository
    {
        List<string> etapes = new List<string>();
        private string[] values = new string[4];
        private string value;

        public bool insert(Entities.Trajet trajet)
        {
            // Ajout du trajet
            string rSQL =
                "INSERT INTO TRAJET (Trajet_Date, Trajet_HeureDepart, Trajet_Commentaire, Trajet_NbPassagers, Vehicule_Id, Utilisateur_Id, Ville_Depart) " +
                "VALUES ('" + trajet.getDate() + "', '" + trajet.getHeure() + "','@commentaire','" + trajet.getNbPassagers() + "','" + trajet.getVehicule() + "','" + trajet.getUtilisateur() + "','" + trajet.getVilleDepart() + "')";

            SqlCommand ajoutTrajet = new SqlCommand(rSQL, Global.dataBase);
            ajoutTrajet.CommandText = rSQL;
            ajoutTrajet.Parameters.AddWithValue("@commentaire", trajet.getCommentaire());

            int result = ajoutTrajet.ExecuteNonQuery();

            ajoutTrajet.Cancel();


            // Récupère dernier id
            rSQL = "SELECT MAX(Trajet_Id) FROM TRAJET";
            SqlCommand lastId  = new SqlCommand(rSQL, Global.dataBase);
            SqlDataReader data = lastId.ExecuteReader();
            var dataRecord = (IDataRecord)data;
            data.Read();
            int id = (int)dataRecord[0];

            trajet.setId(id);

            data.Close();
            lastId.Cancel();


            // Ajout des villes étapes du trajet
            rSQL = "INSERT INTO ETAPE (Trajet_Id, Ville_Nom, Ville_CodePostal, ordre) VALUES ";

            foreach (Etape e in trajet.getListeEtapes()) {
                this.etapes.Add("('" + trajet.getId() + "', '" + e.getVille() + "','" + e.getCodePostal() + "','" + e.getOrdre() + "')");
            }

            value = String.Join(",", this.etapes);
            rSQL += value;

            SqlCommand ajoutEtape = new SqlCommand(rSQL, Global.dataBase);
            result = ajoutEtape.ExecuteNonQuery();

            ajoutEtape.Cancel();


            //Résultat
            if (result >= 1)
                return true;
            else
                return false;
        }

        public bool update(Entities.Trajet trajet)
        {
            return true;
        }

        public bool disable(int id)
        {
                return false;
        }
    }
}
