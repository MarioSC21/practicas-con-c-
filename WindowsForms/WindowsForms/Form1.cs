using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox t1 = new System.Windows.Forms.TextBox();
            t1.Text = "Valor txt";
            t1.Location = new System.Drawing.Point(156, 50);
            t1.Name = "txtApellido";
            t1.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(t1);

            System.Windows.Forms.Button b1 = new System.Windows.Forms.Button();
            b1.Text = "Aceptar";
            b1.Location = new System.Drawing.Point(200, 88);
            b1.Name = "btnAceptar";
            b1.Size = new System.Drawing.Size(88, 20);
            b1.Click += b_Click;
            this.Controls.Add(b1);
        }
        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo....");
        }
    }
}
