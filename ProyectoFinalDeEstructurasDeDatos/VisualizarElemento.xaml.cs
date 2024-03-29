﻿using System;
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
    /// Lógica de interacción para VisualizarElemento.xaml
    /// </summary>
    public partial class VisualizarElemento : UserControl
    {
        public VisualizarElemento()
        {
            InitializeComponent();
            txtboxTitulo.IsEnabled = false;
            txtboxAño.IsEnabled = false;
            comboboxGenero.IsEnabled = false;
            txtboxDirector.IsEnabled = false;
            txtboxSinopsis.IsEnabled = false;
            //txtboxTitulo.Text = Contenido[lstCatalogo.SelectedIndex].Titulo;
        }

        private void btnHabilitarEdicion_Click(object sender, RoutedEventArgs e)
        {
            //grdDatos.Children.Add(new EditarElemento());
            txtboxTitulo.IsEnabled = true;
            txtboxAño.IsEnabled = true;
            comboboxGenero.IsEnabled = true;
            txtboxDirector.IsEnabled = true;
            txtboxSinopsis.IsEnabled = true;
        }

        private void txtboxTitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        
    }
}
