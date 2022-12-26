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
    /// Interaction logic for MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Page
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            load_data();

        }
        private void load_data()
        {
            List<clsCategoria> lst = new List<clsCategoria>();
            using (Model.dbPruebaEntities1 db = new Model.dbPruebaEntities1())
            {
                lst = (from d in db.Categorias
                       select new clsCategoria { id = d.id, Nombre = d.Nombre, Descripcion = d.Descripcion }).ToList();
            }
            DG.ItemsSource = lst;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.StaticMainFrame.Content = new Formulario();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            using (Model.dbPruebaEntities1 db = new Model.dbPruebaEntities1())
            {
                var oCategoria = db.Categorias.Find(id);
                db.Categorias.Remove(oCategoria);
                db.SaveChanges();
            }
            load_data();
            }
        private void Button_Modificar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            Formulario f = new Formulario(id);
            f.id = id;
            MainWindow.StaticMainFrame.Content = f;
        }
    }
    public class clsCategoria
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
