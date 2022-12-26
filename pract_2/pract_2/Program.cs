using System;

namespace pract_2
{
   class Vehiculo
    {
        public string Placa;
        public string Marca;
        public Vehiculo()
        {
            Placa = "value";
        }
        public Vehiculo(string placa)
        {
            this.Placa = placa;
        }
        public Vehiculo(string placa, string Marca):this(placa)
        {
            this.Marca = Marca;
        }

    }
 

    class program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();
            v.Placa = "!1345;";

            Console.WriteLine("{0}", v.Placa);
            Console.ReadLine();

            Vehiculo v1 = new Vehiculo("12333");
            Console.WriteLine("{0}", v1.Placa);
            Console.ReadLine();

            Vehiculo v2 = new Vehiculo("mario123", "toyota");
            Console.WriteLine("{0} {1}" , v2.Placa,v2.Marca);
            Console.ReadLine();
        }
    }
}
