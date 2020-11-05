using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace _5.Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            CreaGridBotones();
        }

        private void CreaGridBotones()
        {
            int indice = 1;
            for (int i = 1; i < CalculadoraGrid.RowDefinitions.Count - 1; i++)
            {
                for (int j = 0; j < CalculadoraGrid.ColumnDefinitions.Count; j++)
                {
                    Button boton = CreaBoton(indice);
                    Grid.SetRow(boton, i);
                    Grid.SetColumn(boton, j);
                    CalculadoraGrid.Children.Add(boton);
                    indice++;
                }
            }
        }

        private Button CreaBoton(int valor)
        {
            //Content
            TextBlock text = new TextBlock();
            text.Text = valor.ToString();

            Viewbox viewbox = new Viewbox();
            viewbox.Child = text;

            //Boton
            Button boton = new Button
            {
                Content = viewbox,
                Tag = valor
            };

            return boton;
        }
    }
}
