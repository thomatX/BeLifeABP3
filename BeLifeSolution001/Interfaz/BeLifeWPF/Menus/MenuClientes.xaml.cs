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
    public partial class MenuClientes : Page
    {
        

        public MenuClientes()
        {
            InitializeComponent();
            CargarSexos();
            CargarEstadosCiviles();
          
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPrincipal());
        }

        private void BtnContraste_Click(object sender, RoutedEventArgs e)
        {
            Menus.AltoContraste.CambiarContraste();
        }

        private void BtnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            FlyAgregarCliente.IsOpen = true;
        }

        private void BtnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            FlyEliminarCliente.IsOpen = true;
        }

        private void BtnModificarCliente_Click(object sender, RoutedEventArgs e)
        {
            FlyModificarCliente.IsOpen = true;
        }

        private void BtnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            FlyListarCliente.IsOpen = true;
        }

        private void BtnMenuContratos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuContrato());
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        { 
            if (TxtNombreAgregar.Text.Equals(String.Empty) ||
                TxtRutAgregar.Text.Equals(String.Empty) ||
                TxtApellidosAgregar.Text.Equals(String.Empty) ||
                FechaNacimientoPicker.SelectedDate == null ||
                SexoComb.SelectedIndex == -1 ||
                EstadoCivilComb.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan campos por rellenar...", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                try
                {

                    BelifeLibrary.Cliente cli = new BelifeLibrary.Cliente();
                    cli.Rut = TxtRutAgregar.Text;
                    cli.Nombres = TxtNombreAgregar.Text;
                    cli.Apellidos = TxtApellidosAgregar.Text;
                    cli.FechaNacimiento = (DateTime)FechaNacimientoPicker.SelectedDate;
                    cli.IdEstadoCivil = EstadoCivilComb.SelectedIndex + 1;
                    cli.IdSexo = SexoComb.SelectedIndex + 1;
                    if (cli.Create())
                    {
                        MessageBox.Show("Cliente agregado correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimpiarCamposAgregar();
                    }
                    else
                    {
                        throw new Exception("¡Ha ocurrido un error!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LimpiarCamposAgregar()
        {
            TxtRutAgregar.Text = String.Empty;
            TxtNombreAgregar.Text = String.Empty;
            TxtApellidosAgregar.Text = String.Empty;
            FechaNacimientoPicker.SelectedDate = DateTime.Today;
            SexoComb.SelectedIndex = -1;
            EstadoCivilComb.SelectedIndex = -1;
        }

        private void CargarSexos()
        {
            BelifeLibrary.Sexo sexo = new BelifeLibrary.Sexo();
            List<BelifeLibrary.Sexo> lista = new List<BelifeLibrary.Sexo>();
            List<string> listadesc = new List<string>();
            lista = sexo.ReadAll();
            foreach(var x in lista)
            {
                listadesc.Add(x.Descripcion);
            }
            SexoComb.ItemsSource = listadesc;
            SexoComb.Items.Refresh();


        }

        private void CargarEstadosCiviles()
        {
            BelifeLibrary.EstadoCivil est = new BelifeLibrary.EstadoCivil();
            List<BelifeLibrary.EstadoCivil> lista = new List<BelifeLibrary.EstadoCivil>();
            List<string> listadesc = new List<string>();
            lista = est.ReadAll();
            foreach (var x in lista)
            {
                listadesc.Add(x.Descripcion);
            }
            EstadoCivilComb.ItemsSource = listadesc;
            EstadoCivilComb.Items.Refresh();


        }


    }
}
