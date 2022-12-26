using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // usando el sistema de configuracion

namespace Practica_Conection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciacion de la clase
            SqlConnection Conexion_appConfig = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString);//pasamos como parametro la
                                                                                                                                         //conexion XML
            Conexion_appConfig.Open(); //abrimos la conexion
            MessageBox.Show("La conexion se ha establecido");  
            Conexion_appConfig.Close(); //cerramos la conexion
        }
    }
}
