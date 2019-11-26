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
    /// Lógica de interacción para VisualizarElementoSerie.xaml
    /// </summary>
    public partial class VisualizarElementoSerie : UserControl
    {
        public VisualizarElementoSerie()
        {
            InitializeComponent();
            txtboxTitulo.IsEnabled = false;
            txtboxTemporadas.IsEnabled = false;
            txtboxAño.IsEnabled = false;
            comboboxGenero.IsEnabled = false;
            txtboxDirector.IsEnabled = false;
            txtboxSinopsis.IsEnabled = false;
        }

        private void txtboxTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
