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
    public partial class Frmdatabase : Form
    {
        public Frmdatabase()
        {
            InitializeComponent();
        }

        private void Frmdatabase_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select dbid,name from sys.sysdatabases", cn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "db");
            cboBasedatos.DataSource = ds.Tables["db"];
            cboBasedatos.DisplayMember = "Name";
            cboBasedatos.ValueMember = "dbid";
        }

        private void btnCargardb_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select object_id,name from " + cboBasedatos.Text + ".sys.tables", cn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tab1");
            cboTablas.DataSource = ds.Tables["tab1"];
            cboTablas.DisplayMember = "name";
            cboTablas.ValueMember = "object_id";
        }

        private void btnCargarTablas_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select object_id,name from " + cboBasedatos.Text + ".sys.all_columns c where c.object_id =" + cboTablas.SelectedValue, cn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "campost1");
            int pos = 10;
            panel_data.Controls.Clear();
            foreach (DataRow xrow in ds.Tables["campost1"].Rows)
              {
                //MessageBox.Show(xrow["name"].ToString());
                crear_campo(xrow["name"].ToString(), pos);
                pos = pos + 25;
            }

        }
        public void crear_campo(string xnamelbl, int posy  )
        {
            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label();
            l1.Location = new System.Drawing.Point(5, posy);
            l1.Name = "l1" + xnamelbl;
            l1.Text = xnamelbl;
            l1.Size = new System.Drawing.Size(60, 20);
            panel_data.Controls.Add(l1);

            System.Windows.Forms.TextBox t1 = new System.Windows.Forms.TextBox();
            t1.Location = new System.Drawing.Point(100, posy);
            t1.Name = "txt" + xnamelbl;
            t1.Size = new System.Drawing.Size(100, 20);
            panel_data.Controls.Add(t1);
        }
    }
}
