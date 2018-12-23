using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Metier
    {
        Client client;

        public Metier()
        {
            client = new Client("medic","user");
        }
    }
}
