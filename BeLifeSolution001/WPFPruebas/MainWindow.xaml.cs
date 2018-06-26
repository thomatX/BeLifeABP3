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

namespace WPFPruebas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BelifeLibrary.Vehiculo veh = new BelifeLibrary.Vehiculo();
                veh.Patente = patenteTxt.Text;
                veh.IdMarca = int.Parse(idMarcaTxt.Text);
                veh.IdModelo = int.Parse(idModeloTxt.Text);
                veh.Anho = int.Parse(anhoTxt.Text);
                if (veh.Create())
                {
                    MessageBox.Show("Agregado exitosamente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
