using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_Comando
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
            SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();
            objBuilder.DataSource = "192.168.0.108"; //Recomendable
            objBuilder.InitialCatalog = "Lab_TAD";
            objBuilder.UserID = "usr_tad";
            objBuilder.Password = "Amigos01";

            objConexion.ConnectionString = objBuilder.ConnectionString; //para hacer la conexion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand objComando = new SqlCommand();
            //objComando.CommandText = "insert into PRODUCTO(PROD_NOMBRE, PROD_MARCA) values('Microondas', 'LG', 'TD-200')"; // se usa para ser (select, update, delete ,insert)
            //objComando.Connection = objConexion; // para que funcione la conexion, sino no va funcionar
            //objComando.CommandType = CommandType.Text; // para ser mas explicito(no es nesesario)
            objComando.CommandText = "Insertar_Producto";
            objComando.Connection = objConexion;
            objComando.CommandType = CommandType.StoredProcedure; // ahora es un proc alamacenado

            //objComando.Parameters.Clear(); //Buena practica hacer limpieza de parametros antes de enviar parametros 
            //objComando.Parameters.AddWithValue("@PROD_NOMBRE", "Mouse"); // para poder agregar valores con el parametro primero y despues el valor que se le da
            //objComando.Parameters.AddWithValue("@PROD_MARCA", "Logitech");
            //objComando.Parameters.AddWithValue("@PROD_MODELO", "G305");

            objComando.Parameters.Clear(); //Buena practica 
            objComando.Parameters.AddWithValue("@PROD_NOMBRE", TxtNombre.Text); // ya usamos los textbox que hemos colocado con la propiedad Text
            objComando.Parameters.AddWithValue("@PROD_MARCA", TxtMarca.Text);
            objComando.Parameters.AddWithValue("@PROD_MODELO", TxtModelo.Text);
            objComando.Parameters.AddWithValue("@PROD_ACTIVO", ChkActivo.Checked);
            objComando.Parameters.AddWithValue("@PROD_FECHA_FAB", DatePicker.Value);

            objConexion.Open(); // para abrir la conexion > se hace una linea antes > para que no este abierta antes de la ejecucion del comando
            objComando.ExecuteNonQuery();//para insert, update, delete > cuando no se requiere recuperar datos(que te muestre los datos)
            objConexion.Close();//apenas termina la conexion se cierra 
            MessageBox.Show("El registro se inserto"); // verificar el sql para ver que se inserto este comando

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand= new SqlCommand();
            sqlCommand.CommandText = "ACTUALIZAR_PRODUCTO";
            sqlCommand.Connection = objConexion;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@PROD_ID", TxtCodigo.Text);
            sqlCommand.Parameters.AddWithValue("@PROD_NOMBRE", TxtNombre.Text);
            sqlCommand.Parameters.AddWithValue("@PROD_MARCA", TxtMarca.Text);
            sqlCommand.Parameters.AddWithValue("@PROD_MODELO", TxtModelo.Text);
            sqlCommand.Parameters.AddWithValue("@PROD_ACTIVO", ChkActivo.Checked);
            sqlCommand.Parameters.AddWithValue("@PROD_FECHA_FAB", DatePicker.Value);

            objConexion.Open();
            sqlCommand.ExecuteNonQuery();
            objConexion.Close();
            MessageBox.Show("El registro se actualizo");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "ELIMINAR_PRODUCTO";
            sqlCommand.Connection = objConexion;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@PROD_ID", TxtCodigo.Text);

            objConexion.Open();
            sqlCommand.ExecuteNonQuery();
            objConexion.Close();
            MessageBox.Show("El registro se elimino");

        }
    }
}
