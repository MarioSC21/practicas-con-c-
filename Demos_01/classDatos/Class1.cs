using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDatos
{
    public class clsproduct
    {
       public int codigo { get; set; }

        public clsproduct() { }
        public clsproduct(int _codigo)
        {
            codigo = _codigo;
        }
        public string imprimir()
        {
            return $"Codigo: {codigo}";
        }
    }
}
