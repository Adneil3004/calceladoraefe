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
using EffectsViewModel.Herramientas;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        Ventanas.Presentacion Prest = new Ventanas.Presentacion();
        Ventanas.CalculosEfect Efectos = new Ventanas.CalculosEfect();
        Ventanas.PresentacionDatos DatosFinales = new Ventanas.PresentacionDatos();

        private ConexionBaseDatos cnx;
        public ConexionBaseDatos Cnx { get => cnx; set => cnx = value; }
     
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           cnx=new ConexionBaseDatos( System.Configuration.ConfigurationManager.ConnectionStrings["DBDiana"].ConnectionString);
        }
        private void MoveWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void DatosConfig_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            grdWindwsContainer.Children.Clear();
            grdWindwsContainer.Children.Add(Efectos);
        }
        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdWindwsContainer.Children.Clear();
            grdWindwsContainer.Children.Add(Prest);
        }
        private void ViewRes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            grdWindwsContainer.Children.Clear();
            grdWindwsContainer.Children.Add(DatosFinales);
        }

       
    }
}
