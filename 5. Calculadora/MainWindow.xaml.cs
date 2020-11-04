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
        List<Button> Botones = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();
            CreaGridBotones();
        }

        private void CreaGridBotones()
        {
            InicializaBotones();
            ColocaBotones();
            AñadeBotones(CalculadoraGrid);
        }

        private void InicializaBotones()
        {
            for (int i = 1; i <= 9; i++)
            {
                Botones.Add(CreaBoton(i));
            }
            Botones.Add(CreaBoton(0));
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

        private void ColocaBotones()
        {
            int indice = 0;
            for (int i = 1; i < CalculadoraGrid.RowDefinitions.Count - 1; i++)
            {
                for (int j = 0; j < CalculadoraGrid.ColumnDefinitions.Count; j++)
                {
                    Grid.SetRow(Botones[indice], i);
                    Grid.SetColumn(Botones[indice], j);
                    indice++;
                }
            }
            Grid.SetRow(Botones[Botones.Count - 1], 4);
            Grid.SetColumn(Botones[Botones.Count - 1], 0);
            Grid.SetColumnSpan(Botones[Botones.Count - 1], 3);
        }

        private void AñadeBotones(Grid grid)
        {
            for (int i = 0; i < 10; i++)
            {
                grid.Children.Add(Botones[i]);
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            numero_TextBlock.Text += button.Tag.ToString();
        }
    }
}
