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
        public Client(string demande1, string demande2)
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
                                if (dataString == null)
                                {
                                    writer.WriteLine(demande1);
                                    dataString = reader.ReadLine().ToString();
                                }
                                else
                                {
                                    writer.WriteLine(demande2);
                                    Console.WriteLine(dataString = dataString + reader.ReadLine());
                                    
                                }

                                
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
    }
}
