using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicStockClient
{
    class Metier
    {
        string dataString;
        Client client;

        public Metier()
        {
            client = new Client();
            dataString = client.getDataString();
        }
    }
}
