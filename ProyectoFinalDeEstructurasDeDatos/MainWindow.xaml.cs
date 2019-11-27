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
        ObservableCollection<Contenido> info = new ObservableCollection<Contenido>();
        //ObservableCollection<Pelicula> peliculas = new ObservableCollection<Pelicula>();
        //ObservableCollection<Serie> series = new ObservableCollection<Serie>();
        public MainWindow()
        {
            InitializeComponent();
        
            Pelicula pelicula1 = new Pelicula("Pelicula","Avatar", 2009, "Ciencia Ficción", "James Cameron",
            "Jake Sully es un marine paralítico que acepta llevar a cabo el trabajo iniciado por su " +
            "hermano gemelo, un experimentado científico que, desgraciadamente, murió durante un atraco: " +
            "conducir el avatar, un cuerpo creado con ADN alienígena y humano, gobernando su mente gracias a " +
            "avanzada tecnología por el planeta Pandora, con el fin de ser aceptado dentro de la tribu de los Na'vi " +
            "y recoger información y muestras de las distintas especies del planeta. ", 4);
            Pelicula pelicula2 = new Pelicula("Pelicula","sffesf", 2019, "Comedia", "James Cameron",
            "asdfghjklñasdfghjksdfghjkadsfghterrert ", 3);
            Serie serie1 = new Serie("Serie","Nom",2, 2014, "Romance", "Yo", "asdfghjklñ", 2);

            info.Add(pelicula1);
            info.Add(pelicula2);
            info.Add(serie1);

            lstCatalogo.ItemsSource = info; 

        }


        private void btnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new AgregarNuevoElementoPelicula());
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAñoA.Visibility = Visibility.Hidden;
            btnAñoB.Visibility = Visibility.Hidden;
            btnGuardarAgregarPelicula.Visibility = Visibility.Visible;
            rbpeli.Visibility = Visibility.Visible;
            rbserie.Visibility = Visibility.Visible;
            TituloNE.Visibility = Visibility.Visible;
            TipoNE.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
        }

        private void lstCatalogo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstCatalogo.SelectedIndex != -1)//cambios
            {

                btnNuevoElemento.Visibility = Visibility.Hidden;
                btnOrdenarAZ.Visibility = Visibility.Hidden;
                btnOrdenarZA.Visibility = Visibility.Hidden;
                btnAñoA.Visibility = Visibility.Hidden;
                btnAñoB.Visibility = Visibility.Hidden;
                btnActualizarEdicion.Visibility = Visibility.Hidden;
                btnEliminarElemento.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
                btnHabilitarEdicion.Visibility = Visibility.Visible;


                /*if(lstCatalogo.SelectedIndex = info.IndexOf(Pelicula))
                {

                }*/
                if(info[lstCatalogo.SelectedIndex].Tipo == "Pelicula" || info[lstCatalogo.SelectedIndex].Tipo == "pelicula")
                {
                    grdDatos.Children.Clear();
                    grdDatos.Children.Add(new VisualizarElemento());
                    ((VisualizarElemento)(grdDatos.Children[0])).txtboxTitulo.Text = info[lstCatalogo.SelectedIndex].Titulo;
                    ((VisualizarElemento)(grdDatos.Children[0])).txtboxAño.Text = info[lstCatalogo.SelectedIndex].Año.ToString();
                    ((VisualizarElemento)(grdDatos.Children[0])).cboxItem.Content = info[lstCatalogo.SelectedIndex].Genero;
                    ((VisualizarElemento)(grdDatos.Children[0])).txtboxDirector.Text = info[lstCatalogo.SelectedIndex].Director;
                    ((VisualizarElemento)(grdDatos.Children[0])).txtboxSinopsis.Text = info[lstCatalogo.SelectedIndex].Sinopsis;
                    ((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text = info[lstCatalogo.SelectedIndex].Rating.ToString();

                    _1_estrella.Visibility = Visibility.Hidden;
                    _2_estrellas.Visibility = Visibility.Hidden;
                    _3_estrellas.Visibility = Visibility.Hidden;
                    _4_estrellas.Visibility = Visibility.Hidden;
                    _5_estrellas.Visibility = Visibility.Hidden;

                    if (((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text == "1")
                    {
                        _1_estrella.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text == "2")
                    {
                        _2_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text == "3")
                    {
                        _3_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text == "4")
                    {
                        _4_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElemento)(grdDatos.Children[0])).txtboxImg.Text == "5")
                    {
                        _5_estrellas.Visibility = Visibility.Visible;
                    }
                    btnEliminarElemento.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                }

                if (info[lstCatalogo.SelectedIndex].Tipo == "Serie" || info[lstCatalogo.SelectedIndex].Tipo == "serie")
                {
                    grdDatos.Children.Clear();
                    grdDatos.Children.Add(new VisualizarElementoSerie());
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxTitulo.Text = info[lstCatalogo.SelectedIndex].Titulo;
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxTemporadas.Text = info[lstCatalogo.SelectedIndex].Temporadas.ToString();
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxAño.Text = info[lstCatalogo.SelectedIndex].Año.ToString();
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).cboxItem.Content = info[lstCatalogo.SelectedIndex].Genero;
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxDirector.Text = info[lstCatalogo.SelectedIndex].Director;
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxSinopsis.Text = info[lstCatalogo.SelectedIndex].Sinopsis;
                    ((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text = info[lstCatalogo.SelectedIndex].Rating.ToString();

                    _1_estrella.Visibility = Visibility.Hidden;
                    _2_estrellas.Visibility = Visibility.Hidden;
                    _3_estrellas.Visibility = Visibility.Hidden;
                    _4_estrellas.Visibility = Visibility.Hidden;
                    _5_estrellas.Visibility = Visibility.Hidden;

                    if (((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text == "1")
                    {
                        _1_estrella.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text == "2")
                    {
                        _2_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text == "3")
                    {
                        _3_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text == "4")
                    {
                        _4_estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarElementoSerie)(grdDatos.Children[0])).txtboxImg.Text == "5")
                    {
                        _5_estrellas.Visibility = Visibility.Visible;
                    }
                    btnEliminarElemento.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                }
            }
        }

        private void btnOrdenarAZ_Click(object sender, RoutedEventArgs e)
        {
            /*int gap, i;
            gap = info.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < info.Count; i++)
                {
                    if (gap + i < info.Count && info[i].Titulo.ToCharArray() > info[gap + i].Titulo)
                    {
                        var temp = info[i];
                        info[i] = info[gap + i];
                        info[gap + i] = temp;

                    }
                }

                gap--;
            }*/
        }

        private void btnAñoA_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = info.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < info.Count; i++)
                {
                    if (gap + i < info.Count && info[i].Año > info[gap + i].Año)
                    {
                        var temp = info[i];
                        info[i] = info[gap + i];
                        info[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void btnOrdenarZA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAñoB_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = info.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < info.Count; i++)
                {
                    if (gap + i < info.Count && info[i].Año < info[gap + i].Año)
                    {
                        var temp = info[i];
                        info[i] = info[gap + i];
                        info[gap + i] = temp;

                    }
                }

                gap--;
            }
        }

        private void btnHabilitarEdicion_Click(object sender, RoutedEventArgs e)
        {
            if (info[lstCatalogo.SelectedIndex].Tipo == "Pelicula" || info[lstCatalogo.SelectedIndex].Tipo == "pelicula")
            {
                grdDatos.Children.Clear();
                _1_estrella.Visibility = Visibility.Hidden;
                _2_estrellas.Visibility = Visibility.Hidden;
                _3_estrellas.Visibility = Visibility.Hidden;
                _4_estrellas.Visibility = Visibility.Hidden;
                _5_estrellas.Visibility = Visibility.Hidden;
                grdDatos.Children.Add(new EditarElemento());
                btnActualizarEdicion.Visibility = Visibility.Visible;
                btnEliminarElemento.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;

                ((EditarElemento)(grdDatos.Children[0])).txtboxTitulo.Text = info[lstCatalogo.SelectedIndex].Titulo;
                ((EditarElemento)(grdDatos.Children[0])).txtboxAño.Text = info[lstCatalogo.SelectedIndex].Año.ToString();
                ((EditarElemento)(grdDatos.Children[0])).cboxItem.Content = info[lstCatalogo.SelectedIndex].Genero;
                ((EditarElemento)(grdDatos.Children[0])).txtboxDirector.Text = info[lstCatalogo.SelectedIndex].Director;
                ((EditarElemento)(grdDatos.Children[0])).txtboxSinopsis.Text = info[lstCatalogo.SelectedIndex].Sinopsis;
                ((EditarElemento)(grdDatos.Children[0])).txtboxRating.Text = info[lstCatalogo.SelectedIndex].Rating.ToString();
            }
            if (info[lstCatalogo.SelectedIndex].Tipo == "Serie" || info[lstCatalogo.SelectedIndex].Tipo == "serie") 
            {
                grdDatos.Children.Clear();
                _1_estrella.Visibility = Visibility.Hidden;
                _2_estrellas.Visibility = Visibility.Hidden;
                _3_estrellas.Visibility = Visibility.Hidden;
                _4_estrellas.Visibility = Visibility.Hidden;
                _5_estrellas.Visibility = Visibility.Hidden;
                grdDatos.Children.Add(new EditarElementoSerie());
                btnActualizarEdicion.Visibility = Visibility.Visible;
                btnEliminarElemento.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;

                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxTitulo.Text = info[lstCatalogo.SelectedIndex].Titulo;
                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxTemporadas.Text = info[lstCatalogo.SelectedIndex].Temporadas.ToString();
                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxAño.Text = info[lstCatalogo.SelectedIndex].Año.ToString();
                ((EditarElementoSerie)(grdDatos.Children[0])).cboxItem.Content = info[lstCatalogo.SelectedIndex].Genero;
                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxDirector.Text = info[lstCatalogo.SelectedIndex].Director;
                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxSinopsis.Text = info[lstCatalogo.SelectedIndex].Sinopsis;
                ((EditarElementoSerie)(grdDatos.Children[0])).txtboxRating.Text = info[lstCatalogo.SelectedIndex].Rating.ToString();
            }

        }

        private void btnActualizarEdicion_Click(object sender, RoutedEventArgs e)
        {
            if (info[lstCatalogo.SelectedIndex].Tipo == "Pelicula" || info[lstCatalogo.SelectedIndex].Tipo == "pelicula")
            {

                //Correción del convert
                grdDatos.Children.Add(new EditarElemento());
                var datos1 = ((EditarElemento)(grdDatos.Children[0]));
                var datos2 = info[lstCatalogo.SelectedIndex];
                var año = datos2.Año.ToString();
                var año2 = Convert.ToInt32(((EditarElemento)(grdDatos.Children[0])).txtboxAño.Text);
                info[lstCatalogo.SelectedIndex].Año = año2;
                var rating = datos2.Rating.ToString();
                var rating2 = Convert.ToInt32(((EditarElemento)(grdDatos.Children[0])).txtboxRating.Text);
                info[lstCatalogo.SelectedIndex].Rating = rating2;

                datos2.Titulo = datos1.txtboxTitulo.Text;
                //datos2.Genero = datos1.cboxItem.Content;
                datos2.Director = datos1.txtboxDirector.Text;
                datos2.Sinopsis = datos1.txtboxSinopsis.Text;

                lstCatalogo.Items.Refresh();
                grdDatos.Children.Clear();
                btnActualizarEdicion.Visibility = Visibility.Hidden;
                btnEliminarElemento.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                ///////////////////////////////////////////////////
                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoA.Visibility = Visibility.Visible;
                btnAñoB.Visibility = Visibility.Visible;
            }

            if (info[lstCatalogo.SelectedIndex].Tipo == "Serie" || info[lstCatalogo.SelectedIndex].Tipo == "serie")
            {
                //Correción del convert
                grdDatos.Children.Add(new EditarElementoSerie());
                var datos1 = ((EditarElementoSerie)(grdDatos.Children[0]));
                var datos2 = info[lstCatalogo.SelectedIndex];
                var año = datos2.Año.ToString();
                var año2 = Convert.ToInt32(((EditarElementoSerie)(grdDatos.Children[0])).txtboxAño.Text);
                info[lstCatalogo.SelectedIndex].Año = año2;
                var rating = datos2.Rating.ToString();
                var rating2 = Convert.ToInt32(((EditarElementoSerie)(grdDatos.Children[0])).txtboxRating.Text);
                info[lstCatalogo.SelectedIndex].Rating = rating2;
                var temporadas = datos2.Temporadas.ToString();
                var temporadas2 = Convert.ToInt32(((EditarElementoSerie)(grdDatos.Children[0])).txtboxTemporadas.Text);
                info[lstCatalogo.SelectedIndex].Temporadas = temporadas2;

                datos2.Titulo = datos1.txtboxTitulo.Text;
                //datos2.Temporadas = datos1.txtboxTemporadas;
                //datos2.Genero = datos1.cboxItem.Content;
                datos2.Director = datos1.txtboxDirector.Text;
                datos2.Sinopsis = datos1.txtboxSinopsis.Text;

                lstCatalogo.Items.Refresh();

                grdDatos.Children.Clear();
                btnActualizarEdicion.Visibility = Visibility.Hidden;
                btnEliminarElemento.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                ///////////////////////////////////////////////////
                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoA.Visibility = Visibility.Visible;
                btnAñoB.Visibility = Visibility.Visible;
            }
              
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdDatos.Children.Clear();
            btnActualizarEdicion.Visibility = Visibility.Hidden;
            btnEliminarElemento.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnHabilitarEdicion.Visibility = Visibility.Hidden;
            ///////////////////////////////////////////////////
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAñoA.Visibility = Visibility.Visible;
            btnAñoB.Visibility = Visibility.Visible;
            //////////////////////////////////////////////////
            _1_estrella.Visibility = Visibility.Hidden;
            _2_estrellas.Visibility = Visibility.Hidden;
            _3_estrellas.Visibility = Visibility.Hidden;
            _4_estrellas.Visibility = Visibility.Hidden;
            _5_estrellas.Visibility = Visibility.Hidden;
            /////////////////////////////////////////////////
            btnGuardarAgregarPelicula.Visibility = Visibility.Hidden;
            btnGuardarAgregarSerie.Visibility = Visibility.Hidden;
            rbpeli.Visibility = Visibility.Hidden;
            rbserie.Visibility = Visibility.Hidden;
            TituloNE.Visibility = Visibility.Hidden;
            TipoNE.Visibility = Visibility.Hidden;
        }

        private void btnGuardarAgregarPelicula_Click(object sender, RoutedEventArgs e)
        {
            /*if(((((NuevoElemento)(grdDatos.Children[0]))).rbpeli.IsChecked == true))
            {
                btnGuardarAgregarPelicula.Visibility = Visibility.Visible;
            }*/
            /*grdDatos.Children.Add(new AgregarNuevoElementoPelicula());
            ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTitulo.Text = info[lstCatalogo.SelectedIndex].Titulo;

            lstCatalogo.Items.Refresh();*/

            /*
            grdDatos.Children.Add(new AgregarNuevoElementoPelicula());
            if (lstCatalogo.SelectedIndex != -1)
            {
                var datos1 = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0]));
                var datos2 = info[lstCatalogo.SelectedIndex];
                var año = datos2.Año.ToString();
                var año2 = Convert.ToInt32(((EditarElemento)(grdDatos.Children[0])).txtboxAño.Text);
                info[lstCatalogo.SelectedIndex].Año = año2;
                var rating = datos2.Rating.ToString();
                var rating2 = Convert.ToInt32(((EditarElemento)(grdDatos.Children[0])).txtboxRating.Text);
                info[lstCatalogo.SelectedIndex].Rating = rating2;

                info[lstCatalogo.SelectedIndex].Titulo = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTitulo.Text;
            }

            lstCatalogo.Items.Refresh();
            grdDatos.Children.Clear();
            */
            /*var añoP = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxAño1.Text;
            int añoB = int.Parse(añoP);
            var ratingP = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxRating1.Text;
            int ratingB = int.Parse(ratingP);


            info.Add(new Pelicula(((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTipo.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTitulo.Text, añoB,((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).comboboxGenero.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxDirector.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxSinopsis.Text, ratingB));
            lstCatalogo.Items.Refresh();
            grdDatos.Children.Clear();*/
        }

        private void btnEliminarElemento_Click(object sender, RoutedEventArgs e)
        {
            if(lstCatalogo.SelectedIndex != -1)
            {
                info.RemoveAt(lstCatalogo.SelectedIndex);
                grdDatos.Children.Clear();
                btnActualizarEdicion.Visibility = Visibility.Hidden;
                btnEliminarElemento.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                ///////////////////////////////////////////////////
                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoA.Visibility = Visibility.Visible;
                btnAñoB.Visibility = Visibility.Visible;
                //////////////////////////////////////////////////
                _1_estrella.Visibility = Visibility.Hidden;
                _2_estrellas.Visibility = Visibility.Hidden;
                _3_estrellas.Visibility = Visibility.Hidden;
                _4_estrellas.Visibility = Visibility.Hidden;
                _5_estrellas.Visibility = Visibility.Hidden;
            }
        }

        private void rbpeli_Checked(object sender, RoutedEventArgs e)
        {
            //grdDatos.Children.Add(new AgregarNuevoElementoPelicula());
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new AgregarNuevoElementoPelicula());
            btnGuardarAgregarSerie.Visibility = Visibility.Hidden;
            btnGuardarAgregarPelicula.Visibility = Visibility.Visible;
        }

        private void rbserie_Checked(object sender, RoutedEventArgs e)
        {
           
            //grdDatos.Children.Add(new AgregarNuevoElementoSerie());
            grdDatos.Children.Clear();
            grdDatos.Children.Add(new AgregarNuevoElementoSerie());
            btnGuardarAgregarPelicula.Visibility = Visibility.Hidden;
            btnGuardarAgregarSerie.Visibility = Visibility.Visible;

        }

        private void btnGuardarAgregarPelicula_Click_1(object sender, RoutedEventArgs e)
        {
            btnGuardarAgregarSerie.Visibility = Visibility.Hidden;
            var añoP = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxAño1.Text;
            int añoB = int.Parse(añoP);
            var ratingP = ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxRating1.Text;
            int ratingB = int.Parse(ratingP);


            info.Add(new Pelicula(((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTipo.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxTitulo.Text, añoB, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).comboboxGenero.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxDirector.Text, ((AgregarNuevoElementoPelicula)(grdDatos.Children[0])).txtboxSinopsis.Text, ratingB));
            
            //visibility
            rbpeli.Visibility = Visibility.Hidden;
            rbserie.Visibility = Visibility.Hidden;
            TituloNE.Visibility = Visibility.Hidden;
            TipoNE.Visibility = Visibility.Hidden;
            btnGuardarAgregarPelicula.Visibility = Visibility.Hidden;
            /////////////////////////////////////////////////////////
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAñoA.Visibility = Visibility.Visible;
            btnAñoB.Visibility = Visibility.Visible;

            lstCatalogo.Items.Refresh();
            grdDatos.Children.Clear();

        }

        private void btnGuardarAgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarAgregarPelicula.Visibility = Visibility.Hidden;
            var añoA = ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxAño.Text;
            int añoC = int.Parse(añoA);
            var ratingA = ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxRating.Text;
            int ratingC = int.Parse(ratingA);
            var temporadasA = ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxTemporadas.Text;
            int temporasdasC = int.Parse(temporadasA);


            info.Add(new Serie(((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxTipo.Text, ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxTitulo.Text,temporasdasC, añoC, ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).comboboxGenero.Text, ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxProductor.Text, ((AgregarNuevoElementoSerie)(grdDatos.Children[0])).txtboxDescripción.Text, ratingC));
            
            //visibility
            rbpeli.Visibility = Visibility.Hidden;
            rbserie.Visibility = Visibility.Hidden;
            TituloNE.Visibility = Visibility.Hidden;
            TipoNE.Visibility = Visibility.Hidden;
            btnGuardarAgregarSerie.Visibility = Visibility.Hidden;
            /////////////////////////////////////////////////////////
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAñoA.Visibility = Visibility.Visible;
            btnAñoB.Visibility = Visibility.Visible;

            lstCatalogo.Items.Refresh();
            grdDatos.Children.Clear();
        }
    }
}
