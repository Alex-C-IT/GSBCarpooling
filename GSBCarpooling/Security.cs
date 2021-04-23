using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GSBCarpooling
{
    public class Security
    {
        public static string Sha256Hash(string rawData)
        {
            // Créé une instance de SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Hachage de la chaine fournie en paramètre.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Instanciation d'un StringBuilder
                StringBuilder builder = new StringBuilder();

                // Lecture du tableau
                for (int i = 0; i < bytes.Length; i++)
                    // Formate chaque caractère du tableau "bytes" en deux caractères hexadécimaux puis l'ajoute à la chaine "builder"
                    builder.Append(bytes[i].ToString("x2"));

                //Retourne la chaine construite.
                return builder.ToString();
            }
        }
    }
}
