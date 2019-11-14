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
using System.Collections.ObjectModel;


namespace ProyectoFinalDeEstructurasDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Pelicula> peliculas = new ObservableCollection<Pelicula>();
        ObservableCollection<Serie> series = new ObservableCollection<Serie>();
        public MainWindow()
        {
            InitializeComponent();
            peliculas.Add(new Pelicula("Avatar", 2009));
            series.Add(new Serie("N",0));

            lstCatalogo.ItemsSource = peliculas;
            lstCatalogo.ItemsSource = series;

        }

        private void btnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Add(new NuevoElemento());
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAñoA.Visibility = Visibility.Hidden;
            btnAñoB.Visibility = Visibility.Hidden;
        }

        private void lstCatalogo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdDatos.Children.Add(new VisualizarElemento());
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAñoA.Visibility = Visibility.Hidden;
            btnAñoB.Visibility = Visibility.Hidden;
        }
    }
}
