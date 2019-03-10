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
        TcpClient ClientTcp;

        public Client(String p_address, Int32 p_port)
        {
           ClientTcp = new TcpClient(p_address, p_port);

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

        public bool sendData(String strToSent)
        {

            try
            {
                using (networkStream = ClientTcp.GetStream())
                {
                    using (StreamReader reader = new StreamReader(networkStream))
                    {
                        using (StreamWriter writer = new StreamWriter(networkStream))
                        {
                            writer.Write(strToSent);
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }

        }
        public string getDataString()
        {
            return dataString;
        }
    }
}
