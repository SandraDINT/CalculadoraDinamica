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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int numeroFilas = gridPrincipal.RowDefinitions.Count - 1;
            int numeroColumnas = gridPrincipal.ColumnDefinitions.Count - 1;
            int contador = 0;
            for (int fila = 0; fila < numeroFilas; fila++)
            {
                for (int columnas = 0; columnas < numeroColumnas; columnas++)
                {
                    Button boton = new Button();
                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columnas);
                    boton.Margin = new Thickness(5);
                    boton.Click += Button_Click;
                    boton.Tag = contador++;
                    TextBlock numeroBoton = new TextBlock();
                    numeroBoton.Text = contador.ToString();
                    Viewbox viewBox = new Viewbox();
                    viewBox.Child = numeroBoton;
                    boton.Content = viewBox;
                    gridPrincipal.Children.Add(boton);
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
