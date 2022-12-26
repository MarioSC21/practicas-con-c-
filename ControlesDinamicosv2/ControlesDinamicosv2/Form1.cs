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

namespace ControlesDinamicosv2
{
    public partial class Form1 : Form
    {
        public int contador = 1;
        public int contador1;
        public int cont = 0;
        public int cont1 = 0;
        public int max = 0;
        public String data;
        public DataSet dsTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            dsTable = new DataSet();
            adapter.Fill(dsTable, "campost1");
            int pos = 10;
            panel_data.Controls.Clear();
            foreach (DataRow xrow in dsTable.Tables["campost1"].Rows)
            {
                //MessageBox.Show(xrow["name"].ToString());
                crear_campo(xrow["name"].ToString(), pos,0);
                pos = pos + 25;
            }
            cont = 0;
        }
        public void crear_campo(string xnamelbl, int posy,int des)
        {
            SqlConnection cn1 = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter adapter1 = new SqlDataAdapter($"select COUNT(*) from {cboBasedatos.Text}.dbo.{cboTablas.Text} ", cn1);

            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "reg1");
            //MessageBox.Show(ds.Tables["reg"].Rows.ToString());
            foreach (DataRow xrow1 in ds1.Tables["reg1"].Rows)
            {
                contador1 = int.Parse(xrow1[cont1].ToString());
                cont1++;
            }
            cont1 = 0;

            //MessageBox.Show(contador1.ToString());
            if(des > 0)
            {
 
                    SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
                    SqlDataAdapter adapter = new SqlDataAdapter($"select * from {cboBasedatos.Text}.dbo.{cboTablas.Text} order by 1 OFFSET {des} ROWS FETCH NEXT 1 ROWS ONLY", cn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "reg");
                    //MessageBox.Show(ds.Tables["reg"].Rows.ToString());
                    foreach (DataRow xrow in ds.Tables["reg"].Rows)
                    {
                        data = xrow[cont].ToString();
                        cont++;
                    }

               
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter($"select * from {cboBasedatos.Text}.dbo.{cboTablas.Text} order by 1 OFFSET {des} ROWS FETCH NEXT 1 ROWS ONLY", cn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "reg");
                //MessageBox.Show(ds.Tables["reg"].Rows.ToString());
                foreach (DataRow xrow in ds.Tables["reg"].Rows)
                {
                    data = xrow[cont].ToString();
                    cont++;
                }
            }
            
            

            System.Windows.Forms.Label l1 = new System.Windows.Forms.Label();
            l1.Location = new System.Drawing.Point(5, posy);
            l1.Name = "l1" + xnamelbl;
            l1.Text = xnamelbl;
            l1.Size = new System.Drawing.Size(60, 20);
            panel_data.Controls.Add(l1);

            System.Windows.Forms.TextBox t1 = new System.Windows.Forms.TextBox();
            t1.Location = new System.Drawing.Point(100, posy);
            t1.Text = data;
            t1.Name = "txt" + xnamelbl;
            t1.Size = new System.Drawing.Size(100, 20);
            panel_data.Controls.Add(t1);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            max++;
            if (max < contador1)
            {
                int pos = 10;
                panel_data.Controls.Clear();
                
                foreach (DataRow xrow in dsTable.Tables["campost1"].Rows)
                {
                    crear_campo(xrow["name"].ToString(), pos, max);
                    pos = pos + 25;
                }
                cont = 0;
            }
            else
            {
                max = contador1-1;
                MessageBox.Show($"Retrocede esta tabla solo tiene {contador1.ToString()} filas");
            }
            

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            max--;
            if (max < contador1 && max >= 0)
            {
                int pos = 10;
                panel_data.Controls.Clear();

                foreach (DataRow xrow in dsTable.Tables["campost1"].Rows)
                {
                    crear_campo(xrow["name"].ToString(), pos, max);
                    pos = pos + 25;
                }
                cont = 0;
            }
            else
            {
                max = 0;
                MessageBox.Show("adelanta, llegaste al inicio de la tabla");
            }
            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            max = contador1-1;
                int pos = 10;
                panel_data.Controls.Clear();

                foreach (DataRow xrow in dsTable.Tables["campost1"].Rows)
                {
                    crear_campo(xrow["name"].ToString(), pos, max);
                    pos = pos + 25;
                }
                cont = 0;

                MessageBox.Show($"Este es final de los registros, esta tabla tiene {contador1.ToString()} filas");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            max = 0;
            int pos = 10;
            panel_data.Controls.Clear();

            foreach (DataRow xrow in dsTable.Tables["campost1"].Rows)
            {
                crear_campo(xrow["name"].ToString(), pos, max);
                pos = pos + 25;
            }
            cont = 0;
            MessageBox.Show("Este es el inicio de la tabla");
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
