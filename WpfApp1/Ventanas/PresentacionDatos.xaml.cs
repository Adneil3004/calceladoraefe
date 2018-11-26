using EffectsViewModel;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para PresentacionDatos.xaml
    /// </summary>
    public partial class PresentacionDatos : UserControl
    {
        DataTable res;
        public PresentacionDatos()
        {
            
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }     
    }
}
