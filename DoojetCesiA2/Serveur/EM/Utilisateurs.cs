using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2.EM
{
    public class Utilisateurs
    {

        //verify if the specified combo user/pass corresponds to an entry in the database
        public static string SELECT_BY_USERPASS(string user, string hashed_pass)
        {
            return $"SELECT UID FROM utilisateurs WHERE username = '{user}' and pass = '{hashed_pass}';";
        }

        
    }
}
