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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double PrimerNumero;
        Double SegundoNumero;
        Double Resultado;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sumar(object sender, RoutedEventArgs e)
        {
            PrimerNumero = Double.Parse(numero1.Text);
            SegundoNumero = Double.Parse(numero2.Text);

            Resultado = PrimerNumero + SegundoNumero;

            resultado.Content = Resultado.ToString();
        }

        private void Restar(object sender, RoutedEventArgs e)
        {
            PrimerNumero = Double.Parse(numero1.Text);
            SegundoNumero = Double.Parse(numero2.Text);

            Resultado = PrimerNumero - SegundoNumero;

            resultado.Content = Resultado.ToString();
        }

        private void Multiplicar(object sender, RoutedEventArgs e)
        {
            PrimerNumero = Double.Parse(numero1.Text);
            SegundoNumero = Double.Parse(numero2.Text);

            Resultado = PrimerNumero * SegundoNumero;

            resultado.Content = Resultado.ToString();
        }

        private void Dividir(object sender, RoutedEventArgs e)
        {
            PrimerNumero = Double.Parse(numero1.Text);
            SegundoNumero = Double.Parse(numero2.Text);

            Resultado = PrimerNumero / SegundoNumero;

            resultado.Content = Resultado.ToString();
        }
    }
}
