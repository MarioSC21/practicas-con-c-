using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AppValidarIngresoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patron = "[1-3][AB][0-9]";
            Regex regex = new Regex(patron);
            string data;

            Console.WriteLine("Ingrese codigo");
            data = Console.ReadLine();
            if (regex.IsMatch(data))
            {
                Console.WriteLine("Codigo OK");
            }
            else
            {
                Console.WriteLine("Codigo False");
            }
            Console.ReadLine();
        }
    }
}
