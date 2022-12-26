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
using System.Data.SqlClient;

namespace Practica_ConectionXML
{
    public partial class Form1 : Form
    {
        SqlConnection objConexion = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\mario\\Documents\\Visual Studio trabajos (TAD)\\Practica_ConectionXML\\Practica_ConectionXML\\bin\\Debug\\Conection.XML");
            XmlNodeList conec = doc.SelectNodes("Conection");
            XmlNode cone1;

            for (int i = 0; i < conec.Count; i++)
            {
                cone1 = conec.Item(i);

                string conexio = cone1.SelectSingleNode("nombre").InnerText;
                string dataBase = cone1.SelectSingleNode("nombre1").InnerText;
                string Ide = cone1.SelectSingleNode("nombre2").InnerText;
                string password = cone1.SelectSingleNode("nombre3").InnerText;

                SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();
                objBuilder.DataSource = conexio;
                objBuilder.InitialCatalog = dataBase;
                objBuilder.UserID = Ide;
                objBuilder.Password = password;

                objConexion.ConnectionString = objBuilder.ConnectionString;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            objConexion.Open();
            MessageBox.Show("Estado de la Conexion : " + objConexion.State);
            objConexion.Close();

        }
    }
}
