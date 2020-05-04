using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2.CAM
{
    public class Authentifier
    {

        public STR_MSG Dispatch(STR_MSG msg)
        {
            if (msg.appname == "DooJet" && msg.appV == "V1")
            {
                Controller.AuthentifierV1 authentifierV1 = new Controller.AuthentifierV1();
                return authentifierV1.Exec(msg);
            }
            else
            {
                msg.status = false;
                msg.info = "Error, undefined appname or version.";
            }
            return msg;
        }
    }
}
