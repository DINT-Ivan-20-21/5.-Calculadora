using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _5.Calculadora
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            (MainWindow as MainWindow).Button_Click(sender, e);
        }
    }
}
