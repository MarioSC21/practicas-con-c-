using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //proveedor de acceso de datos para SQL Server

namespace laboratorio
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
            //objConexion.ConnectionString = "Server=.;Database=Lab_TAD;Integrated Security=true"; //Windows autentication
            //objConexion.ConnectionString = "Server=192.168.0.108;Database=Lab_TAD;Integrated Security=true";
            //objConexion.ConnectionString = "Server=Mario;Database=Lab_TAD;Integrated Security=true"; //hostname
            //objConexion.ConnectionString = "Server = 192.168.0.108;Database = Lab_TAD;User ID = usr_tad;Pwd = 123";

            SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();
            objBuilder.DataSource = "192.168.0.108"; //Recomendable
            //objBuilder.DataSource = "Mario"; //Recomendable
            objBuilder.InitialCatalog = "Lab_TAD";
            //objBuilder.IntegratedSecurity = true; //Autenticacion por Windows
            objBuilder.UserID = "usr_tad";
            objBuilder.Password = "Amigos01";
            //objBuilder.Encrypt = true; // solo se puede utilizar si el Sql tiene un certificado

            //objBuilder.ConnectTimeout = 15;
            objConexion.ConnectionString = objBuilder.ConnectionString;

            //MessageBox.Show("Tiempo de conexion : " + objBuilder.ConnectTimeout); //Para dar tiempo a que se reconecte
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            objConexion.Open();
            MessageBox.Show("Estado de la Conexion : " + objConexion.State);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objConexion.Close();
            MessageBox.Show("Estado de la Conexion : " + objConexion.State);
        }
    }
}
