using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LecturaXml
{
    internal class Program
    {
        public static String placa;
        static void Main(string[] args)
        {
            //Cambiar la ruta 
            XmlReader reader = XmlReader.Create(@"C:\Users\mario\Documents\Isur netFramework\LecturaXml\LecturaXml\garaje.xml");
            
            while (reader.Read())//valor booleano
            {
                if (reader.IsStartElement())
                {
                    if (reader.HasAttributes)
                    {
                        placa = reader.GetAttribute(0);
                    }
                    if (reader.Name.ToString() == "marca")
                    {  
                        Console.WriteLine($"La marca del carro con la placa {placa} es : {reader.ReadString()}");
                    }
                    if(reader.Name.ToString() == "precio")
                    {
                        Console.WriteLine($"El precio es: {reader.ReadString()}\n");

                    }
                    
                }
            }
            Console.WriteLine("Enter para salir");
            Console.ReadLine();
        }
    }
}
