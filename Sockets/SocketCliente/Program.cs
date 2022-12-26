using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;            
using System.Net.Sockets;

namespace SocketCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conectar();
        }
        public static void Conectar()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint direccionLocal = new IPEndPoint(IPAddress.Parse("192.168.0.117"), 1234);//colocamos la IP de nuestro computador local
                                                                                               //comnado: ipconfig en cmd
            try
            {
                socket.Connect(direccionLocal); // Conectamos               
                Console.WriteLine("Conectado con exito");
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
