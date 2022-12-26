using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //

namespace Lab_DataReader
{
    public partial class FrmBuscar : Form
    {
        public DataGridViewRow objFilaSeleccionada; // DataGridViewRow > Clase que nos permite  saber lo seleccionado
        public FrmBuscar()
        {
            InitializeComponent();
        }
        public FrmBuscar(SqlDataReader objLector)
        {
            InitializeComponent();
            DataTable objTabla = new DataTable();
            objTabla.Load(objLector);
            DgvProducto.DataSource = objTabla;
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            objFilaSeleccionada = DgvProducto.SelectedRows[0];
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            objFilaSeleccionada = null;
            this.Close();
        }
    }
}
