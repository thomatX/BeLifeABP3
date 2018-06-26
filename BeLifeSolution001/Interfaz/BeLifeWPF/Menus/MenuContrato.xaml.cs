using System;
using System.Collections.Generic;
using System.Globalization;
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
using MahApps.Metro.Controls;


namespace BeLifeWPF
{
    /// <summary>
    /// Lógica de interacción para MenuClientes.xaml
    /// </summary>
    public partial class MenuContrato : Page
    {
        

        public MenuContrato()
        {
            InitializeComponent();
            ComboTipoContrato.Items.Add("1");
            ComboTipoContrato.Items.Add("2");
            ComboTipoContrato.Items.Add("3");


        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPrincipal());
        }

        private void BtnContraste_Click(object sender, RoutedEventArgs e)
        {
            Menus.AltoContraste.CambiarContraste();
        }

        

        private void BtnMenuCliente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuClientes());

        }

        private void BtnAgregarContrato_Click(object sender, RoutedEventArgs e)
        {
            Fly_AgregarContrato.IsOpen = true;
        }

        private void BtnTerminarContrato_Click(object sender, RoutedEventArgs e)
        {
            FlyTerminarContrato.IsOpen = true;
        }

        private void BtnModificarContrato_Click(object sender, RoutedEventArgs e)
        {
            FlyModificarContrato.IsOpen = true;   
        }

        private void BtnListarContratos_Click(object sender, RoutedEventArgs e)
        {
            FlyListarContratos.IsOpen = true;
        }

        private void ComboTipoContrato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboTipoContrato.SelectedValue.ToString().Equals("2"))
            {
                GridHogar.Visibility = System.Windows.Visibility.Visible;
            }
            
        }
    }
}
