using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2.CUT
{
    public class TraitementUtilisateur
    {
        Serveur serveur;
        public STR_MSG authentifier(STR_MSG msg)
        {
            //on passe directement au message_handler, le wcf n'etant pas encore réalisé
            msg.operationName = "auth";
            msg = setAppNameVersion(msg);
            return serveur.Service(msg);
        }

        public TraitementUtilisateur()
        {
            serveur = new Serveur();
        }

        private STR_MSG setAppNameVersion(STR_MSG msg)
        {
            msg.appname = "DooJet";
            msg.appV = "V1";
            return msg;
        }
    }
}
