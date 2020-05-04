using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2.Services
{
    public class GestionComptesUtilisateurs
    {

        public STR_MSG Authentifier(STR_MSG msg)
        {
            CAM.Authentifier CamAuthentifier = new CAM.Authentifier();
            return CamAuthentifier.Dispatch(msg);
        }
    }
}
