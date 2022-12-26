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

namespace Controles_Dinamicos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Server=.;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select dbid, name from sys.sysdatabases", cn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "db"); 

            cmbBaseDatos.DataSource = ds.Tables[0];
            cmbBaseDatos.DisplayMember = "name";
            cmbBaseDatos.ValueMember = "dbid";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
       
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            label2.Name = "label2";
            label2.Text = "Tablas";
            label2.Location = new System.Drawing.Point(248, 101);
            label2.Size = new System.Drawing.Size(80, 13);
            this.Controls.Add(label2);

            System.Windows.Forms.ComboBox cmbBaseDatos2 = new System.Windows.Forms.ComboBox();
            cmbBaseDatos2.Name = "cmbBaseDatos2";
            cmbBaseDatos2.Location = new System.Drawing.Point(248,120);
            cmbBaseDatos2.Size = new System.Drawing.Size(229, 21);
            this.Controls.Add(cmbBaseDatos2);

            System.Windows.Forms.Button btnBuscar2 = new System.Windows.Forms.Button();
            btnBuscar2.Text = "Buscar";
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Location = new System.Drawing.Point(556, 120);
            btnBuscar2.Size = new System.Drawing.Size(87, 23);

            //Conexion dos
            SqlConnection cn2 = new SqlConnection($"Server=.;Database={cmbBaseDatos.Text};Integrated Security=True");
            SqlDataAdapter adapter2 = new SqlDataAdapter("select object_id, name from sys.tables", cn2);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "db2");

            cmbBaseDatos2.DataSource = ds2.Tables[0];
            cmbBaseDatos2.DisplayMember = "name";
            cmbBaseDatos2.ValueMember = "object_id";

            btnBuscar2.Click += (se, eve) =>
            {
                System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
                label3.Name = "label2";
                label3.Text = "Columnas";
                label3.Location = new System.Drawing.Point(248, 238);
                label3.Size = new System.Drawing.Size(80, 13);
                this.Controls.Add(label3);

                System.Windows.Forms.ComboBox cmbBaseDatos3 = new System.Windows.Forms.ComboBox();
                cmbBaseDatos3.Name = "cmbBaseDatos3";
                cmbBaseDatos3.Location = new System.Drawing.Point(248, 257);
                cmbBaseDatos3.Size = new System.Drawing.Size(210, 21);
                this.Controls.Add(cmbBaseDatos3);

                System.Windows.Forms.Button btnBuscar3 = new System.Windows.Forms.Button();
                btnBuscar3.Text = "Buscar";
                btnBuscar3.Name = "btnBuscar3";
                btnBuscar3.Location = new System.Drawing.Point(556, 247);
                btnBuscar3.Size = new System.Drawing.Size(87, 23);
                //recuprando el id del comboBox
                int id = int.Parse(cmbBaseDatos2.SelectedValue.ToString());
                //Conexion tres
                SqlConnection cn3 = new SqlConnection($"Server=.;Database={cmbBaseDatos.Text};Integrated Security=True");
                SqlDataAdapter adapter3 = new SqlDataAdapter($"select id, name from sys.syscolumns where id = {id}", cn3);
                DataSet ds3 = new DataSet();
                adapter3.Fill(ds3, "db3");

                cmbBaseDatos3.DataSource = ds3.Tables[0];
                cmbBaseDatos3.DisplayMember = "name";
                cmbBaseDatos3.ValueMember = "id";

                this.Controls.Add(btnBuscar3);
            };
            this.Controls.Add(btnBuscar2);

        }
    }
}
