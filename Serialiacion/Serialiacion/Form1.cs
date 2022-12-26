using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using System.Xml.Serialization;

namespace Serialiacion
{
    public partial class Form1 : Form
    {
        clsEmpleados x = new clsEmpleados(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            clsEmpleado empleado = new clsEmpleado();
            empleado.ID = int.Parse(txtId.Text);
            empleado.Nombres = txtNombre.Text;
            empleado.Apellidos = txtApellido.Text;
            empleado.Celular = txtCelular.Text;
            empleado.Email = txtEmail.Text;

            x.lista.Add(empleado);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\Isur netFramework\\myEmpleados.bin", FileMode.Create,FileAccess.Write,FileShare.None);

            formatter.Serialize(stream, x);
            stream.Close();
        }

        private void btndeser_Click(object sender, EventArgs e)
        {
            clsEmpleado objEmpleado;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\Isur netFramework\\myEmpleado.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            objEmpleado = (clsEmpleado) formatter.Deserialize(stream);
            stream.Close();

            txtId.Text = objEmpleado.ID.ToString();
            txtNombre.Text = objEmpleado.Nombres.ToString();
            txtApellido.Text = objEmpleado.Apellidos.ToString();
            txtCelular.Text = objEmpleado.Celular.ToString();
            txtEmail.Text = objEmpleado.Email.ToString();
        }

        private void btnSerXml_Click(object sender, EventArgs e)
        {
            clsEmpleado empleado = new clsEmpleado();
            empleado.ID = int.Parse(txtId.Text);
            empleado.Nombres = txtNombre.Text;
            empleado.Apellidos = txtApellido.Text;
            empleado.Celular = txtCelular.Text;
            empleado.Email = txtEmail.Text;

            Stream stream = new FileStream("D:\\Isur netFramework\\myEmpleado.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            XmlSerializer xmlSerializer = new XmlSerializer(empleado.GetType()); //obtner la serailzacion
            xmlSerializer.Serialize(stream,empleado);
            stream.Close();
        }

        private void btnDesSerXml_Click(object sender, EventArgs e)
        {
            clsEmpleado objEmpleado;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(clsEmpleado));
            Stream stream = new FileStream("D:\\Isur netFramework\\myEmpleado.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            objEmpleado = (clsEmpleado)xmlSerializer.Deserialize(stream);
            stream.Close();

            txtId.Text = objEmpleado.ID.ToString();
            txtNombre.Text = objEmpleado.Nombres.ToString();
            txtApellido.Text = objEmpleado.Apellidos.ToString();
            txtCelular.Text = objEmpleado.Celular.ToString();
            txtEmail.Text = objEmpleado.Email.ToString();
        }
    }
}
