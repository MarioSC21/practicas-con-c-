using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosolaApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classDatos.clsproduct datos = new classDatos.clsproduct(1);
            Console.WriteLine("coloque un numero");
            datos.codigo = int.Parse(Console.ReadLine()) ;
            Console.WriteLine($"{datos.imprimir()}");
            Console.ReadLine();
            
        }
    }
}
 