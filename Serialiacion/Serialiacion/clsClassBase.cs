using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialiacion
{
    [Serializable]
    public class clsEmpleado
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        [NonSerialized()] public string Email;
    }
    [Serializable]
    public class clsEmpleados
    {
        public List<clsEmpleado> lista = new List<clsEmpleado>();
    }
}
