using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControlErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cls_entidades.ClsEmpleado x = new Cls_entidades.ClsEmpleado();
            Console.WriteLine("Ingreso Empleados");
            Console.WriteLine("1.Nuwvo");
            Console.WriteLine("Ingrese el codigo");
            x.codigo = int.Parse(Console.ReadLine());
            x.codigo = int.Parse(Console.ReadLine());
            x.codigo = int.Parse(Console.ReadLine());
            x.codigo = int.Parse(Console.ReadLine());
            x.codigo = int.Parse(Console.ReadLine());

            StreamWriter file = File.CreateText("empleados.txt");
            file.WriteLine(x.codigo);

            StreamReader mifile = File.OpenText("empleados.txr");
            string linea = mifile.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(mifile.ReadLine());
                linea = mifile.ReadLine();
            }
        }
    }
}
