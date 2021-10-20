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
            CrearBotonesCalculadora();
        }
        private void CrearBotonesCalculadora()
        {
            for (int fila = 1; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    //Calculamos el número correspondiente a este botón
                    int n = (fila - 1) * 3 + columna + 1;

                    //Creamos y configuramos el botón
                    Button boton = new Button();
                    Grid.SetRow(boton, fila - 1);
                    Grid.SetColumn(boton, columna);
                    boton.Margin = new Thickness(5);
                    boton.Tag = n;

                    //Creamos y configuramos el contenido del botón
                    TextBlock texto = new TextBlock();
                    texto.Text = n.ToString();
                    Viewbox box = new Viewbox();
                    box.Child = texto;
                    boton.Content = box;

                    //Introducimos el botón en el Grid
                    gridPrincipal.Children.Add(boton);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            textBlockPantalla.Text += boton.Tag.ToString();
        }
    }
}
