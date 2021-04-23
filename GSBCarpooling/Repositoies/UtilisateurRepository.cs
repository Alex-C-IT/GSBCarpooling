using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSBCarpooling.Repositoies
{
    class UtilisateurRepository
    {
        public bool insert(Utilisateur user)
        {
            string rSQL =
                "INSERT INTO UTILISATEUR(Utilisateur_Nom, Utilisateur_Prenom, Utilisateur_Pseudonyme, Utilisateur_HashPassword, Utilisateur_DateNaissance, Utilisateur_Rue, Utilisateur_Email, Utilisateur_TelMobile, Utilisateur_Sexe, Utilisateur_DateInscription, Utilisateur_PremiereConnexion, Ville_Nom, Ville_CodePostal, TypeUtilisateur_Id, Utilisateur_Actif) " +
                "VALUES ('"+ user.getNom() +"', '"+ user.getPrenom() +"', '"+ user.getPseudonyme() + "', '"+ user.getHashpassword() + "', '"+ user.getDateNaissance() + "', '" + user.getRue() + "', '" + user.getEmail() + "', '" + user.getMobile() + "', '" + user.getSexe() + "', '" + user.getDateInscription() + "', '" + 1 + "', '" + user.getVille() + "', '" + user.getCodePostal() + "', '" + user.getTypeUtilisateur() +"', " + 1 + ")";

            SqlCommand ajoutUser = new SqlCommand(rSQL, Global.dataBase);

            int result = ajoutUser.ExecuteNonQuery();

            ajoutUser.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }

        public bool update(Utilisateur user)
        {
            string rSQL =
                "UPDATE UTILISATEUR " +
                "SET Utilisateur_Nom = '" + user.getNom() + "', " +
                "Utilisateur_Prenom = '" + user.getPrenom() + "', " +
                "Utilisateur_Pseudonyme = '" + user.getPseudonyme() + "', " +
                "Utilisateur_DateNaissance = '" + user.getDateNaissance() + "', " +
                "Utilisateur_Rue = '" + user.getRue() + "', " +
                "Utilisateur_TelMobile = '" + user.getMobile() + "', " +
                "Utilisateur_Sexe = '" + user.getSexe() + "', " +
                "Utilisateur_DateInscription = '" + user.getDateInscription() + "', " +
                "Utilisateur_PremiereConnexion = '" + 0 + "', " +
                "Ville_Nom = '" + user.getVille() + "', " +
                "Ville_CodePostal = '" + user.getCodePostal() + "', " +
                "TypeUtilisateur_Id = '" + user.getTypeUtilisateur() + "' " +
                "WHERE Utilisateur_Id = " + user.getId();

            SqlCommand modifierUser = new SqlCommand(rSQL, Global.dataBase);

            int result = modifierUser.ExecuteNonQuery();

            modifierUser.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }

        public bool disable(int id)
        {
            string rSQL =
                "UPDATE UTILISATEUR " +
                "SET Utilisateur_Actif = 0 " +
                "WHERE Utilisateur_Id = " + id;

            SqlCommand disableUser = new SqlCommand(rSQL, Global.dataBase);
            int result = disableUser.ExecuteNonQuery();
            disableUser.Cancel();

            if (result >= 1)
                return true;
            else
                return false;
        }
    }
}
