using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conectar(); //llamando a la funcion conectar
        }
        public static void Conectar ()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Creacion del socket
            IPEndPoint direccionLocal = new IPEndPoint(IPAddress.Any, 1234);

            //IPAddress.Any significa que va a escuchar al cliente en toda la red
            try
            {
                socket.Bind(direccionLocal); //asociando el socket con nuestra direccion
                socket.Listen(1); // en escucha

                Console.WriteLine("Socket en escucha .....");

                Socket Escuchar = socket.Accept();//creacion del nuevo socket, la apk queda en reposo hasta
                                                  //que el socket se conecte aun cliente

                Console.WriteLine("Se conecto perfectamente");

                socket.Close(); //para cerrar el socket

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
