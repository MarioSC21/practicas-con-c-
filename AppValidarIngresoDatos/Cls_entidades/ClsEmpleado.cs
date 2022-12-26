using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls_entidades
{
    public class ClsEmpleado
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipo_documento { get; set; }
        public string nro_doc { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Contrato { get; set; }
        public Double basico { get; set; }

    }
}
