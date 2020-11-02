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
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            numero_TextBlock.Text += button.Tag.ToString();
        }
    }
}
