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

namespace WindowsForms
{
    public partial class Form2 : Form

    {

       
        public Form2()
        {
            InitializeComponent();

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label();
            l1.Location = new System.Drawing.Point(37, 34);
            l1.Name = "l1";
            l1.Text = "Usuario";
            l1.Size = new System.Drawing.Size(40, 18);
            this.Controls.Add(l1);

            System.Windows.Forms.Label l2 = new System.Windows.Forms.Label();
            l2.Location = new System.Drawing.Point(40, 67);
            l2.Name = "l2";
            l2.Text = "Clave";
            l2.Size = new System.Drawing.Size(40, 18);
            this.Controls.Add(l2);

            System.Windows.Forms.TextBox t1 = new System.Windows.Forms.TextBox();
            t1.Location = new System.Drawing.Point(115, 26);
            t1.Name = "txtUsuario";
            t1.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(t1);

            System.Windows.Forms.TextBox t2 = new System.Windows.Forms.TextBox();
            t2.Location = new System.Drawing.Point(115, 60);
            t2.Name = "txtClave";
            t2.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(t2);

            System.Windows.Forms.Button b1 = new System.Windows.Forms.Button();
            b1.Text = "Aceptar";
            b1.Location = new System.Drawing.Point(260, 20);
            b1.Name = "btnAceptar";
            b1.Size = new System.Drawing.Size(88, 20);
            b1.Click += b_Click;
            this.Controls.Add(b1);

            System.Windows.Forms.Button b2 = new System.Windows.Forms.Button();
            b2.Text = "Salir";
            b2.Location = new System.Drawing.Point(260, 60);
            b2.Name = "btnAceptar";
            b2.Size = new System.Drawing.Size(88, 20);
            //b2.Click += b_Click;
            this.Controls.Add(b2);

        }
        private void b_Click(object sender, EventArgs e)
        {
            if ( this.Controls["txtusuario"].Text=="luis" & this.Controls["txtclave"].Text == "123")
            {
                MessageBox.Show("Hola Luis");
            }
            else
            {
                MessageBox.Show("Usuario y Clave errada");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select dbid,name from sys.sysdatabases", cn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db");
            comboBox1.DataSource = ds.Tables["db"];
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "dbid";
            //comboBox1.Refresh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mostrar las tablas " + comboBox1.Text);
        }
    }
    
}
