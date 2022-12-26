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

namespace ExParcialCRUD
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        int valorChecked;
        Boolean valorCheck;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtCantidad.Text != "" && txtEnPedido.Text != "" && txtExsiste.Text != "" && txtNuevoPedido.Text != "" && txtPrecio.Text != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB01;Integrated Security=True");
                    con.Open();
                    if (chkSuspendido.Checked)
                    {
                        valorChecked = 1;
                    }
                    else
                    {
                        valorChecked = 0;
                    }
                    cmd = new SqlCommand($"insert into Productos(NombreProducto,IdCategorías,CantidadPorUnidad,PrecioUnidad,UnidadesEnExistencia,UnidadesEnPedido,NivelNuevoPedido,Suspendido) " +
                        $"values('{txtNombre.Text}', {(cmbCategoria.SelectedValue.ToString())}, '{txtCantidad.Text}', {txtPrecio.Text}, {txtExsiste.Text}, {txtEnPedido.Text}, {txtNuevoPedido.Text}, {valorChecked})", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se inserto con exito");
                    cargarDatos();
                    limpiarDatos();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("NO PUEDES DEJAR VACIO LOS CAMPOS");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB01;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select id,nombre from Categorias", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "category");
                cmbCategoria.DataSource = ds.Tables["category"];
                cmbCategoria.DisplayMember = "nombre";
                cmbCategoria.ValueMember = "id";

                cargarDatos();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void cargarDatos()
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=.;Initial Catalog=DB01;Integrated Security=True");
                SqlDataAdapter adapter2 = new SqlDataAdapter("select id,NombreProducto,IdCategorías,CantidadPorUnidad,PrecioUnidad,UnidadesEnExistencia,UnidadesEnPedido,NivelNuevoPedido,Suspendido " +
                    "from Productos ", con2);
                DataTable dt = new DataTable();
                adapter2.Fill(dt);
                datagrid.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void limpiarDatos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cmbCategoria.DataSource = null;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtExsiste.Text = "";
            txtEnPedido.Text = "";
            txtNuevoPedido.Text = "";
            chkSuspendido.Checked = false;
        }

        //evento de clicl datagriew
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = datagrid.Rows[e.RowIndex];
                if (row.Cells[8].Selected)
                {
                    valorCheck = true;
                }
                else
                {
                    valorCheck = false;
                }
                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                /*cmbCategoria.SelectedValue = row.Cells[3].ToString();*/
                txtCantidad.Text = row.Cells[3].Value.ToString();
                txtPrecio.Text = row.Cells[4].Value.ToString();
                txtExsiste.Text = row.Cells[5].Value.ToString();
                txtEnPedido.Text = row.Cells[6].Value.ToString();
                txtNuevoPedido.Text = row.Cells[7].Value.ToString();
                chkSuspendido.Checked = valorCheck;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtCantidad.Text != "" && txtEnPedido.Text != "" && txtExsiste.Text != "" && txtNuevoPedido.Text != "" && txtPrecio.Text != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB01;Integrated Security=True");
                    con.Open();
                    if (chkSuspendido.Checked)
                    {
                        valorChecked = 1;
                    }
                    else
                    {
                        valorChecked = 0;
                    }
                    cmd = new SqlCommand($"UPDATE Productos set NombreProducto = '{txtNombre.Text}',IdCategorías = {(cmbCategoria.SelectedValue.ToString())}," +
                        $"CantidadPorUnidad = '{txtCantidad.Text}'," +
                        $"PrecioUnidad = {txtPrecio.Text}," +
                        $"UnidadesEnExistencia = {txtExsiste.Text}," +
                        $"UnidadesEnPedido = {txtEnPedido.Text}," +
                        $"NivelNuevoPedido = {txtNuevoPedido.Text}," +
                        $"Suspendido = {valorChecked} where id = {txtId.Text}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se actualizo con exito");
                    cargarDatos();
                    limpiarDatos();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("NO PUEDES DEJAR VACIO LOS CAMPOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtId.Text) != 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DB01;Integrated Security=True");
                    con.Open();

                    cmd = new SqlCommand($"delete Productos where id = {txtId.Text}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se elimino con exito");
                    cargarDatos();
                    limpiarDatos();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("El id no puede ser cero");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            
        }
    }
}
