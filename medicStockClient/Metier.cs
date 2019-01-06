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

            int i = 0;
            char delimiteur = '%';

            dataString = client.getDataString();
            string[] tabData = dataString.Split(delimiteur);

            delimiteur = '\\';
            string[] tabMedic = tabData[0].Split(delimiteur);
            string[] tabUser = tabData[1].Split(delimiteur);

            delimiteur = ';';
            string 
            foreach (string medic in tabMedic)
                Console.WriteLine(medic);

            
        }
    }
}
