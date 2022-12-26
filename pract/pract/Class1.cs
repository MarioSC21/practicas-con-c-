using System;

namespace pract
{
    public class Cuadrado
    {
        double _dblLado;

        public double Lado { get { return _dblLado; } set { _dblLado = value; } }

        public void ModificarLado(double ML)
        {
            _dblLado = ML;
        }
        public double ConsultarLado()
        {
            return _dblLado;
        }
        public double CalcularPerimetro()
        {
            return 4 * _dblLado;
        }
        public double CalcularArea()
        {
            return Math.Pow(_dblLado, 2);
        }
    }


    class program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();

            c.ModificarLado(5);

            Console.WriteLine("Tu lado  es : {1} ,El perimetro es : {2},El area es : {3}", c.ConsultarLado(), c.CalcularPerimetro(), c.CalcularArea());
            Console.ReadLine();
        }

    }
}
