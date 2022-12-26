using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Contador : UserControl
    {
        [Category("MyProperties")]
        public int MaxValue { get; set; }
        [Category("MyProperties")]
        public int MinValue { get; set; }
        [Category("MyProperties")]
        public int Value {
            get
            {
               return int.Parse(txtValue.Text); 
            } set
            {
                txtValue.Text = value.ToString();
            } }
        public Contador()  
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtValue.Text) < MaxValue)
            {
                txtValue.Text = (int.Parse(txtValue.Text) + 1).ToString();
            }
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtValue.Text) > MinValue){
                txtValue.Text = (int.Parse(txtValue.Text) - 1).ToString();
            }
            
        }
    }
}
