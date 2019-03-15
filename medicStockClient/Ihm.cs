using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    public class Ihm
    {
        Metier metier;
        public Ihm()
        {
            metier = new Metier();
        }

        public int getAuthentification(String p_login, String p_password)
        {
            return metier.Authentification(p_login, p_password);
        }
    }
}
