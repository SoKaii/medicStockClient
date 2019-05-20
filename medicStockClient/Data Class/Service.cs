using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Service
    {
        int id;
        String nom;

        public Service()
        {
            id = 0;
            nom = null;
        }

        public Service(int p_id, String p_nom)
        {
            id = p_id;
            nom = p_nom;
        }

        public int getId()
        { return id; }

        public String getNom()
        { return nom; }
    }
}
