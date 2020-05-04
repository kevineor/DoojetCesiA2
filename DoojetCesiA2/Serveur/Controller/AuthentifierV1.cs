using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2.Controller
{
    public class AuthentifierV1
    {
        CAD cad;
        string req_sql;
        public STR_MSG Exec(STR_MSG msg)
        {
            req_sql = EM.Utilisateurs.SELECT_BY_USERPASS(msg.username, msg.userpass);
            System.Data.DataSet result;
            result = cad.getRows(req_sql, "UID");
            if (result.Tables["UID"].Rows.Count == 1)
            {
                msg.status = true;
                msg.info = "Authentification Success !";
            }
            else
            {
                msg.status = false;
                msg.info = "Authentification Failure !";
            }
            return msg;
        }


        public AuthentifierV1()
        {
            cad = new CAD();
        }
    }
}
