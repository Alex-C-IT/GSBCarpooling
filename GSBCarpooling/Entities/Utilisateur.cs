using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCarpooling.Repositoies;

namespace GSBCarpooling
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private string pseudonyme;
        private DateTime dateDeNaissance;
        private string rue;
        private string ville;
        private string codePostal;
        private string email;
        private string telephone;
        private string sexe;
        private DateTime dateDInscription;
        private string typeUtilisateur;
        private bool premiereConnexion;
        private string hashPassword;

        public Utilisateur(
            int id,
            string nom, 
            string prenom, 
            string pseudonyme, 
            DateTime dateDeNaissance, 
            string rue, 
            string ville,
            string codePostal,
            string email,
            string telephone,
            string sexe,
            DateTime dateDInscription,
            string typeUtilisateur,
            bool premiereConnexion,
            string hashPassword = null)
        {
            if(!(id == 0))
                this.id = id;

            this.nom = nom;
            this.prenom = prenom;
            this.pseudonyme = pseudonyme;
            this.dateDeNaissance = dateDeNaissance;
            this.rue = rue;
            this.ville = ville;
            this.codePostal = codePostal;
            this.email = email;
            this.telephone = telephone;
            this.sexe = sexe;
            this.dateDInscription = dateDInscription;
            this.typeUtilisateur = typeUtilisateur;
            this.premiereConnexion = premiereConnexion;

            if (hashPassword != null)
                this.hashPassword = hashPassword;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public string getPseudonyme()
        {
            return this.pseudonyme;
        }

        public DateTime getDateNaissance()
        {
            return this.dateDeNaissance;
        }

        public string getRue()
        {
            return this.rue;
        }

        public string getVille()
        {
            return this.ville;
        }

        public string getCodePostal()
        {
            return this.codePostal;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getMobile()
        {
            return this.telephone;
        }

        public string getSexe()
        {
            return this.sexe;
        }

        public DateTime getDateInscription()
        {
            return this.dateDInscription;
        }

        public string getHashpassword()
        {
            return this.hashPassword;
        }
        public void setHashpassword(string hashPassword)
        {
            this.hashPassword = hashPassword;
        }

        public bool getPremiereConnexion()
        {
            return this.premiereConnexion;
        }
        public void setPremiereConnexion(bool premiereConnexion)
        {
            this.premiereConnexion = premiereConnexion;
        }

        public string getTypeUtilisateur()
        {
            return this.typeUtilisateur;
        }

        public void setTypeUtilisateur(string typeUtilisateur)
        {
            string[] types = { "ADMIN", "USER" };

            if(types.Contains(typeUtilisateur)) {
                this.typeUtilisateur = typeUtilisateur;
            }
        }

        public bool ajouterUtilisateur()
        {
            // Ajout de l'utilisateur
            return (new UtilisateurRepository()).insert(this);
        }

        public bool modifierUtilisateur()
        {
            // Modification de l'utilisateur
            return (new UtilisateurRepository()).update(this);
        }
        public bool desactiverUtilisateur()
        {
            // Désactivation de l'utilisateur
            return (new UtilisateurRepository()).disable(this.getId());
        }

        public bool changerMotDePasse()
        {
            // Changer mot de passe utilisateur
            return (new UtilisateurRepository()).changerMotDePasse(this);
        }
    }
}
