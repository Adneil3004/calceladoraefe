using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using EffectsViewModel;

namespace WpfApp1.Ventanas
{
    /// <summary>
    /// Lógica de interacción para CalculosEfect.xaml
    /// </summary>
    public partial class CalculosEfect : UserControl    {
        int numeffec=0;
        public CalculosEfect()
        {
            InitializeComponent();
            DataContext = new BsCalcViewModel();
        }

        private void Effect_selection(object sender, MouseEventArgs e)=> (sender as Border).Background = new SolidColorBrush(Color.FromArgb(0xFF,0xEE,0xEC,0xEC));

        private void Effect_deselect(object sender, MouseEventArgs e)=>(sender as Border).Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF));
        
        private void Calcs_selection(object sender, MouseEventArgs e) => (sender as Border).Background = new SolidColorBrush(Color.FromArgb(0xFF,0xB2, 0xA4, 0xFF));

        private void Calcs_deselect(object sender, MouseEventArgs e) => (sender as Border).Background = new SolidColorBrush(Color.FromArgb(0xFF,0x1B,0x51,0xAA));

        private void chkbNAOH_Checked(object sender, RoutedEventArgs e)
        {
            if(chkbNAOH.IsChecked==true)
            {
                chkbInorg.IsChecked = false;
                chkborg.IsChecked = false;
            }
        }

        private void chkbInorg_Checked(object sender, RoutedEventArgs e)
        {
            if ( chkbInorg.IsChecked == true)
            {
                chkbNAOH.IsChecked = false;
                chkborg.IsChecked = false;
            }
        }

        private void chkborg_Checked(object sender, RoutedEventArgs e)
        {
            if (chkborg.IsChecked == true)
            {
                chkbNAOH.IsChecked = false;
                chkbInorg.IsChecked = false;
            }
        }

        //llevar al view-model
        private void Valida_soloNumeros(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9||e.Key==Key.OemPeriod)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btn3Efect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btn3Efect.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xEE, 0xEC, 0xEC));
            btn4Efect.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFf, 0xFF));
            lblU4.Visibility = Visibility.Hidden;
            txtU4.Visibility = Visibility.Hidden;
            DataTable efectos3 = new EffectsViewModel.BsCalcViewModel().cargaArreglos3efect();
            cbArreglo.ItemsSource = ((IListSource)efectos3).GetList();
            cbArreglo.DisplayMemberPath = "Configuracion";
            cbArreglo.SelectedValuePath = "idArreglo";
            numeffec = 3;
        }

        private void btn4Efect_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            btn4Efect.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xEE, 0xEC, 0xEC));
            btn3Efect.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFf, 0xFF));
            lblU4.Visibility = Visibility.Visible;
            txtU4.Visibility = Visibility.Visible;
            DataTable efectos4 = new EffectsViewModel.BsCalcViewModel().cargaArreglos4efect();
            cbArreglo.ItemsSource = ((IListSource)efectos4).GetList(); ;
            cbArreglo.DisplayMemberPath = "Configuracion";
            cbArreglo.SelectedValuePath = "idEfecto";
            numeffec = 4;
        }

        private void btnCalculos_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            
        }


    }
}
