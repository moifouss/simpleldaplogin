using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace WpfLogin.Model
{
    class Authentification
    {
        public static bool Authentifier(string Compte, string ModeDePasse)
        {
            //On doit faire une requette ici qui retourne la valeur true ou false
            return true; 
        }
        public static bool Authenticate(string userName,string password, string domain="bvgctr")
        {

            if (userName == "" || password == "")
            {
                return false;
            }

            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("https://dc3-2k3.ldaps.bvg-mali.local");
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }
    }
}
