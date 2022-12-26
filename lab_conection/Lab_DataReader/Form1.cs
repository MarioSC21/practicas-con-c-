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

namespace Lab_DataReader
{
    public partial class BtnBuscar : Form
    {
        SqlConnection objConexion = new SqlConnection();
        public BtnBuscar()
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader objLector;
                SqlCommand objComnado = new SqlCommand();
                objComnado.CommandText = "AYUDA_PRODUCTO";
                objComnado.Connection = objConexion;
                objComnado.CommandType = CommandType.StoredProcedure;
                objComnado.Parameters.Clear();
                objConexion.Open();
                objLector = objComnado.ExecuteReader(); // Se usa el Reader para mostrar los resultados de las consultas //Se le asigna al objeto del DATAREADER


                FrmBuscar objBuscar = new FrmBuscar(objLector);
                objBuscar.ShowDialog(this);
                if (objBuscar.objFilaSeleccionada != null)
                {
                    objComnado.CommandText = "SELECCIONA_UN_PRODUCTO";
                    objComnado.Connection = objConexion;
                    objComnado.CommandType = CommandType.StoredProcedure;
                    objComnado.Parameters.Clear();
                    objComnado.Parameters.AddWithValue("@PROD_ID", objBuscar.objFilaSeleccionada.Cells[0].Value); //Primer valor el Parametro, Segundo valor el valor que se le asigna
                    objLector.Close(); // cerramos el objeto lector
                    objLector = objComnado.ExecuteReader();
                    objLector.Read(); //Importante el READ para leer ,sino no va funcionar
                    TxtCodigo.Text = objLector.GetValue(objLector.GetOrdinal("PROD_ID")).ToString();
                    TxtNombre.Text = objLector.GetValue(objLector.GetOrdinal("PROD_NOMBRE")).ToString();
                    TxtMarca.Text = objLector.GetValue(objLector.GetOrdinal("PROD_MARCA")).ToString();
                    objConexion.Close();//solo para prueba porque no estamos contando los null
                    TxtModelo.Text = objLector.GetValue(objLector.GetOrdinal("PROD_MODELO")).ToString();
                    DatePicker.Value = Convert.ToDateTime(objLector.GetValue(objLector.GetOrdinal("PROD_FECHA_FAB")));
                    ChkActivo.Checked = Convert.ToBoolean(objLector.GetValue(objLector.GetOrdinal("PROD_ACTIVO")).ToString());
                    objConexion.Close();//solo para prueba porque no estamos contando los null 
                }
                objConexion.Close();

                /*DataTable objTabla = new DataTable();
                objTabla.Load(objLector);//transforma en una estructura date Table

                DgvProducto.DataSource = objTabla; //Para la Griya reciba los valores del DataReader*/ //LO pasamos al constructor del otro Formulario


                //objConexion.Close();//no usamos el close por precausion
                //Se hace de manera demostrativa
                /*if (objLector.HasRows)
                {
                    objLector.Read();//Primer Registro
                    MessageBox.Show(objLector.GetValue(0).ToString());
                    MessageBox.Show(objLector.GetValue(1).ToString());

                    objLector.Read();//Salto de segundo Registro
                    MessageBox.Show(objLector.GetValue(0).ToString());
                    MessageBox.Show(objLector.GetValue(1).ToString());

                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
