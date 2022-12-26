using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace LecturaClaseXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string msg = "";
            xmlDoc.Load("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                msg = msg + " ID: "+node.Attributes["id"].Value + "\n";
                for(int i = 0; i < node.ChildNodes.Count; i++)
                {
                    msg = msg + node.ChildNodes[i].Name + ":" + node.ChildNodes[i].InnerText + "\n";
                }
            }
            MessageBox.Show(msg);
        }

        private void btnXml2_Click(object sender, EventArgs e)
        {
            String msg = "";
            XmlReader reader = XmlReader.Create("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
            while (reader.Read())
            {
                if (reader.Name.ToString() == "nombre")
                {
                    msg = msg + reader.Name.ToString() + reader.ReadString() + "\n";
                }
                if (reader.Name.ToString() == "telefono")
                {
                    msg = msg + reader.Name.ToString() + reader.ReadString() + "\n";
                }

            }
            MessageBox.Show(msg);
        }

        private void btnUpdateXml_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                if(node.Attributes["id"].Value == txtID.Text)
                {
                    XmlElement element = (XmlElement)node.ChildNodes[1];
                    element.InnerText = txtTelefono.Text;
                    
                }
                
            }
            xmlDoc.Save("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                if (node.Attributes["id"].Value == txtID.Text)
            {
                XmlElement element = (XmlElement)node;
                element.RemoveAll();

            }
            xmlDoc.Save("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");

            XmlNode nodo = xmlDoc.CreateElement("empleado");
            XmlAttribute x = xmlDoc.CreateAttribute("id");
            nodo.Attributes.Append(x);

            xmlDoc.AppendChild(nodo);
            
            xmlDoc.Save("D:\\Isur netFramework\\LecturaClaseXml\\LecturaClaseXml\\Empleados.xml");
        }
    }
}
