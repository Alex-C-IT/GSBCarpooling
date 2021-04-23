using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSBCarpooling
{
    public enum modeOuverture
    {
        CREATION,
        MODIFICATION,
        COPIE
    }
    static class Global
    {
        public static Utilisateur user = null;
        public static SqlConnection dataBase;
        public static bool logOK = false;
        
    }
}
