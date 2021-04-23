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
                "VALUES ('" + vehicule.getMarque() + "', '" + vehicule.getModele() + "', '" + vehicule.getAnnee() + "', '" + vehicule.getCouleur() + "', '" + vehicule.getNbPlaces() + "', '" + vehicule.getSociete() + "', '" + vehicule.getImmatriculation() + "', '" + vehicule.getCarburant() + "', '" + vehicule.getUtilisateur() + "', '" + vehicule.getTypeVehicule() + "', 1)";

            SqlCommand ajoutCar = new SqlCommand(rSQL, Global.dataBase);

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
                "SET Vehicule_Marque = '" + car.getMarque() + "', " +
                "Vehicule_Modele = '" + car.getModele() + "', " +
                "Vehicule_Annee = '" + car.getAnnee() + "', " +
                "Vehicule_Couleur = '" + car.getCouleur() + "', " +
                "Vehicule_NbPlaces = '" + car.getNbPlaces() + "', " +
                "Vehicule_societe = '" + car.getSociete() + "', " +
                "Vehicule_immatriculation = '" + car.getImmatriculation() + "', " +
                "Carburant_Id = '" + car.getCarburant() + "', " +
                "Utilisateur_Id = '" + car.getUtilisateur() + "', " +
                "TypeVehicule_Id = '" + car.getTypeVehicule() + "' " +
                "WHERE Vehicule_Id = " + car.getId();

            SqlCommand modifierCar = new SqlCommand(rSQL, Global.dataBase);

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
