using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWpfApp1
{
    /// <summary>
    /// Interaction logic for Formulario.xaml
    /// </summary>
    public partial class Formulario : Page
    {
        public int id = 0;
        public Formulario(int id=0)
        {
            InitializeComponent();
            if (id!=0)
            {
                using (Model.dbPruebaEntities1 db = new Model.dbPruebaEntities1())
                {
                    var oCategoria = db.Categorias.Find(id);
                    txid.Text = oCategoria.id.ToString();
                    txNombre.Text = oCategoria.Nombre;
                    txDescripcion.Text = oCategoria.Descripcion;
}
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if(id==0)
            {
                using (Model.dbPruebaEntities1 db = new Model.dbPruebaEntities1())
                {
                    var oCategoria = new Model.Categorias();
                    oCategoria.Nombre = txNombre.Text;
                    oCategoria.Descripcion = txDescripcion.Text;
                    db.Categorias.Add(oCategoria);
                    db.SaveChanges();
                    MainWindow.StaticMainFrame.Content = new MenuPrincipal();
                }
            }
            else 
            {
                using (Model.dbPruebaEntities1 db = new Model.dbPruebaEntities1())
                {
                    var oCategoria = db.Categorias.Find(id);
                    oCategoria.Nombre = txNombre.Text;
                    oCategoria.Descripcion = txDescripcion.Text;
                    db.Entry(oCategoria).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MainWindow.StaticMainFrame.Content = new MenuPrincipal();
                }
            }



        }
    }
}
