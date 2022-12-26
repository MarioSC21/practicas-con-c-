using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace prjCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartClient();
            Console.ReadKey();

        }
        public static void StartClient()
        {
            byte[] bytes=new byte[1024];
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = ipHostInfo.AddressList[1];
            IPEndPoint remoteEP =new IPEndPoint(iPAddress, 11000);
            Socket socket= new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(remoteEP);
                Console.WriteLine("Se conecto satisfactoriamente");
                byte[] msg = Encoding.ASCII.GetBytes("Hola Server.como estas |");
                int bytesSent = socket.Send(msg);  
                int bytesReceived = socket.Receive(bytes);
                Console.WriteLine("Rpta: {0}",Encoding.ASCII.GetString(bytes,0,bytesReceived));
                socket.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);            }
            

        }

    }
}
