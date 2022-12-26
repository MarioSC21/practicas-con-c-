using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesFuncionalidad
{
    public class Class1
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        
        //constructor
        public Class1()
        {

        }
        public Class1(int dni,string nombres, string apellidos, string direccion)
        {
            Dni = dni;
            Nombre = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
        }
    }
    public class cslClientes
    {
        //Class1[] nClientes = new Class1[10];
        List<Class1> clientes = new List<Class1>();
        public void AddClient(Class1 x)
        {
            clientes.Add(x);
        }
        public void DeleteClient(Class1 x)
        {
            clientes.Remove(x);
        }
        public void UpdateClient(int dni, Class1 x)
        {
            foreach(Class1 i in clientes)
            {
                if(i.Dni == dni)
                {
                    clientes.Remove(i);
                    clientes.Add(x);
                    break;
                }
            }
        }
        public Class1 selectuno(int dni)
        {
            Class1 xcliente = null;
            foreach (Class1 i in clientes)
            {
                if (i.Dni == dni)
                {
                    xcliente = i;
                    break;
                }
            }
            return (xcliente);
        }
    }
}
