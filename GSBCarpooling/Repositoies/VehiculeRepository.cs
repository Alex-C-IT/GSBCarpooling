using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GSBCarpooling.Entities;

namespace GSBCarpooling.Repositoies
{
    class VehiculeRepository
    {
        public bool insert(Vehicule vehicule)
        {
            string rSQL =
                "INSERT INTO VEHICULE(Vehicule_Marque, Vehicule_Modele, Vehicule_Annee, Vehicule_Couleur, Vehicule_NbPlaces, Vehicule_societe, Vehicule_immatriculation, Carburant_Id, Utilisateur_Id, TypeVehicule_Id, Vehicule_Actif) " +
                "VALUES ('@marque', '@modele', '@annee', '@couleur', '@nbPlaces', '" + vehicule.getSociete() + "', '@immatriculation', '@carburant', '@utilisateur', '" + vehicule.getTypeVehicule() + "', 1)";

            SqlCommand ajoutCar = new SqlCommand(rSQL, Global.dataBase);
            ajoutCar.CommandText = rSQL;
            ajoutCar.Parameters.AddWithValue("@marque", vehicule.getMarque());
            ajoutCar.Parameters.AddWithValue("@modele", vehicule.getModele());
            ajoutCar.Parameters.AddWithValue("@annee", vehicule.getAnnee());
            ajoutCar.Parameters.AddWithValue("@couleur", vehicule.getCouleur());
            ajoutCar.Parameters.AddWithValue("@nbPlaces", vehicule.getNbPlaces());
            ajoutCar.Parameters.AddWithValue("@immatriculation", vehicule.getImmatriculation());
            ajoutCar.Parameters.AddWithValue("@carburant", vehicule.getCarburant());
            ajoutCar.Parameters.AddWithValue("@utilisateur", vehicule.getUtilisateur());

            int result = ajoutCar.ExecuteNonQuery();

            ajoutCar.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }

        public bool update(Vehicule car)
        {
            string rSQL =
                "UPDATE VEHICULE " +
                "SET Vehicule_Marque = '@marque', " +
                "Vehicule_Modele = '@modele', " +
                "Vehicule_Annee = '@annee', " +
                "Vehicule_Couleur = '@couleur', " +
                "Vehicule_NbPlaces = '@nbPlaces', " +
                "Vehicule_societe = '" + car.getSociete() + "', " +
                "Vehicule_immatriculation = '@immatriculation', " +
                "Carburant_Id = '@carburant', " +
                "Utilisateur_Id = '@utilisateur', " +
                "TypeVehicule_Id = '" + car.getTypeVehicule() + "' " +
                "WHERE Vehicule_Id = " + car.getId();

            SqlCommand modifierCar = new SqlCommand(rSQL, Global.dataBase);
            modifierCar.CommandText = rSQL;
            modifierCar.Parameters.AddWithValue("@marque", car.getMarque());
            modifierCar.Parameters.AddWithValue("@modele", car.getModele());
            modifierCar.Parameters.AddWithValue("@annee", car.getAnnee());
            modifierCar.Parameters.AddWithValue("@couleur", car.getCouleur());
            modifierCar.Parameters.AddWithValue("@nbPlaces", car.getNbPlaces());
            modifierCar.Parameters.AddWithValue("@immatriculation", car.getImmatriculation());
            modifierCar.Parameters.AddWithValue("@carburant", car.getCarburant());
            modifierCar.Parameters.AddWithValue("@utilisateur", car.getUtilisateur());
            int result = modifierCar.ExecuteNonQuery();

            modifierCar.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }

        public bool disable(int id)
        {
            string rSQL =
                "UPDATE VEHICULE " +
                "SET Vehicule_Actif = 0 " +
                "WHERE Vehicule_Id = " + id;

            SqlCommand disableCar = new SqlCommand(rSQL, Global.dataBase);
            int result = disableCar.ExecuteNonQuery();
            disableCar.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }
    }
}
