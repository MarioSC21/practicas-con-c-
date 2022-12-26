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
using System.Configuration;

namespace Comando
{
    public partial class FrmUsuario : Form
    {
        SqlConnection objConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString);
        SqlCommand objComando = new SqlCommand();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
            try
            {
                /*objConexion.ConnectionString = "Server=.;Database=TAD2020II;Integrated Security=SSPI;";*/
                objComando.Connection = objConexion; //para hacer conexion con el objeto de SqlComand
                objComando.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizar método Add para agregar parámetros al comando
                objComando.CommandText = "Isertar_Usuario"; //Proc para insertar
                objComando.Parameters.Clear();
                objComando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = TxtCorreo.Text; // para especificar el Type de manera mas explicita
                objComando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = TxtClave.Text;
                objComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = TxtNombre.Text;
                objConexion.Open();
                objComando.ExecuteNonQuery(); // necesario para ejecutar los datos
                MessageBox.Show("El registro se insertó", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objConexion.Close();

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizar método AddRange para agregar parámetros al comando
                objComando.CommandText = "Actaulizar_Usuario";
                objComando.Parameters.Clear();
                //El AddRange se usa para añadir un rango de parametros, se usa con SqlParameter
                //Forma 1 para Usar el AddRange con List
                /*List<SqlParameter> listParametro = new List<SqlParameter>();
                listParametro.Add(new SqlParameter("@Id", TxtID.Text));
                listParametro.Add(new SqlParameter("@Correo", TxtCorreo.Text));
                listParametro.Add(new SqlParameter("@Clave", TxtClave.Text));
                listParametro.Add(new SqlParameter("@Nombre", TxtNombre.Text));
                objComando.Parameters.AddRange(listParametro.ToArray<SqlParameter>());*/

                //Segunda forma para usar el Addrange con Arrays 
                objComando.Parameters.AddRange(new SqlParameter[]{new SqlParameter("@Id",TxtID.Text),new SqlParameter("@Correo", TxtCorreo.Text), 
                                                                  new SqlParameter("@Clave", TxtClave.Text), new SqlParameter("@Nombre", TxtNombre.Text) }); // Es un array de parametros
                objConexion.Open();
                objComando.ExecuteNonQuery();
                MessageBox.Show("El registro se actualizó", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objConexion.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizar método AddWithValue para agregar parámetros al comando
                objComando.CommandText = "Eliminar_Usuario";
                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@Id",TxtID.Text);
                objConexion.Open();
                objComando.ExecuteNonQuery();
                MessageBox.Show("El registro se eliminó", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objConexion.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
