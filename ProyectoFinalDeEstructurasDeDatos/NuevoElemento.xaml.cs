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

namespace ProyectoFinalDeEstructurasDeDatos
{
    /// <summary>
    /// Lógica de interacción para NuevoElemento.xaml
    /// </summary>
    public partial class NuevoElemento : UserControl
    {
        public NuevoElemento()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            grdNuevoElemento.Children.Add(new AgregarNuevoElementoPelicula());
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            grdNuevoElemento.Children.Add(new AgregarNuevoElementoPelicula());
        }
    }
}
