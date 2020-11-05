using System.Windows;
using System.Windows.Controls;

namespace _5.Calculadora
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            ((MainWindow as MainWindow).FindName("numero_TextBlock") as TextBlock).Text += button.Tag.ToString();
        }
    }
}
