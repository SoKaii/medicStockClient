using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace medicStockClient
{
    class Client
    {
        private string dataString = null;
        private NetworkStream networkStream = null;
        private string adress;
        private int port;
        private TcpClient ClientTcp;
        private StreamReader reader;
        private StreamWriter writer;
        private String strToSent;
        bool updated = false;
        private List<String> listUpdateCommands = new List<String>(); // Liste de toutes les commandes SQL générées durant l'utilisation de l'application 


        public Client(String p_address, Int32 p_port)
        {
            ClientTcp = new TcpClient(p_address, p_port);
            adress = p_address;
            port = p_port;
            try
            {
                networkStream = ClientTcp.GetStream();
                writer = new StreamWriter(networkStream);
                reader = new StreamReader(networkStream);

                writer.AutoFlush = true;
                dataString = reader.ReadLine();
            }
            catch (Exception e)
            {
                throw new InvalidCastException(e.Message);
            }
        }

        public void AddCommands(string p_id, string p_type, string p_date, string p_quantity, string p_ean, string p_login, string p_nLot)
        {
           listUpdateCommands.Add("INSERT INTO interaction VALUES ('" + p_id + "','" + p_type + "','" + p_date + "','" + p_quantity + "','" + p_ean + "','" + p_login + "','" + p_nLot + "');");
        }

        public void AddCommandsNewUser(string p_login, string p_nom, string p_prenom, string p_admin, string p_password)
        {
            listUpdateCommands.Add("INSERT INTO user VALUES ('" + p_login + "','" + p_nom + "','" + p_prenom + "','" + p_admin + "',MD5('" + p_password + "'));");
        }

        public void AddCommandsNewMedic(string p_ean, string p_nom, string p_forme, string p_dosage, string p_categorie, string p_substance)
        {
            listUpdateCommands.Add("INSERT INTO medicament VALUES ('" + p_ean + "','" + p_nom + "','" + p_categorie + "','" + p_substance + "','" + p_forme + "','" + p_dosage + "');");
        }

        public void sendData()
        {
            try
            {
                if (listUpdateCommands.Count > 0)
                {
                    listUpdateCommands[listUpdateCommands.Count -1].Trim(';');

                    foreach (string str in listUpdateCommands)
                    {
                        strToSent = strToSent + str;
                    }
                    writer.WriteLine(strToSent);
                }
            }
            catch (Exception e)
            {
                throw new InvalidCastException(e.Message);
            }
        }
        public string getDataString()
        {
            return dataString;
        }

        public void closeConnection()
        {
            writer.WriteLine("-1");
        }
    }
}
