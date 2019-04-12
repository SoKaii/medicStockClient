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
        string dataString = null;
        NetworkStream networkStream = null;
        string adress;
        int port;
        TcpClient ClientTcp;
        StreamReader reader;
        StreamWriter writer;
        

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

        public void sendData(List<String> strToSent)
        {
            try
            {
                 writer.WriteLine(strToSent);
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
    }
}
