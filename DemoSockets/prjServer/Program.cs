using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace prjServer
{
    internal class Program
    {
        
        public class clsServidor
        {
            public static string data = null;
            public static void StartListening()
            {
                byte[] bytes = new byte[1024];
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress iPAddress = ipHostInfo.AddressList[1];
                IPEndPoint remoteEP = new IPEndPoint(iPAddress, 11000);
                Socket socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Bind(remoteEP);
                    socket.Listen(10);
                    while(true)
                    {
                       Console.WriteLine("Esperando al cliente....");
                       Socket handler = socket.Accept();
                        data = null;
                        while(true)
                        {
                            int bytesRec = handler.Receive(bytes);
                            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            if(data.IndexOf("|") >-1)
                            { break; }
                        }
                        Console.WriteLine(data);
                        byte[] msg = Encoding.ASCII.GetBytes("Todo OK");
                        handler.Send(msg);
                        handler.Close();
                        Console.ReadKey();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public static int Main(String[] args)
            {
                StartListening();
                return 0;
            }
        }
    }
}
