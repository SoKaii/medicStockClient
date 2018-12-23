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
        public Client()
        {
            string address = "localhost";
            Int32 port = 22;
            NetworkStream networkStream = null;
            TcpClient ClientTcp = new TcpClient(address, port);

            try
            {
                using (networkStream = ClientTcp.GetStream())
                {
                    using (StreamReader reader = new StreamReader(networkStream))
                    {
                        using (StreamWriter writer = new StreamWriter(networkStream))
                        {
                            writer.AutoFlush = true;
                            while (true)
                            {
                                dataString = reader.ReadLine();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getDataString()
        {
            return dataString;
        }
    }
}
