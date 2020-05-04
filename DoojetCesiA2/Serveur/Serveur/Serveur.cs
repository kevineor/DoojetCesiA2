using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2
{
    public class Serveur
    {
        Services.GestionComptesUtilisateurs gestionComptesUtilisateur;

        public STR_MSG Service(STR_MSG msg)
        {
            switch(msg.operationName)
            {
                case "auth":
                    return gestionComptesUtilisateur.Authentifier(msg);

                default:
                    msg.status = false;
                    msg.info = "invalid OperationName";
                    break;
            }
            return msg;
        }

        public Serveur()
        {
            gestionComptesUtilisateur = new Services.GestionComptesUtilisateurs();
        }
    }
}
