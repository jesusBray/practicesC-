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

namespace Ejercicio12
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1, num2,resul;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clicResultado(object sender, RoutedEventArgs e)
        {
            char letra1;
           
            letra1 = char.Parse(txtDato1.Text);

            if (letra1 == 'a' || letra1 == 'e' || letra1 == 'i' || letra1 == 'o' || letra1 == 'u')
            {
                MessageBox.Show("El caracter es una bocal");
            }
            else
            {
                MessageBox.Show("El caracter no es una bocal");
            }
            
        }

        private void clicresutlado2(object sender, RoutedEventArgs e)
        {

            num1 = double.Parse(txtDatoNumero.Text);
            num2 = double.Parse(txtDatoNumero2.Text);
            if(num1> num2){
                MessageBox.Show("Resultado "+num1+": "+num2);
            }
            else
            {
                MessageBox.Show("Resultado " + num2 + ": " + num1);
            }
        }

        private void clicNumero3(object sender, RoutedEventArgs e)
        {
            Random aleatorio = new Random();
            double num1 = aleatorio.Next(1, 7);
            double num2 = aleatorio.Next(1, 7);
            lblDado1.Content = num1;
            lblDado2.Content = num2;
            if(num1 == (num2-1) || num2 == (num1-1)){
                lblResul.Content=("El nuemero es una escalera "+num1+" : "+num2);
            }
            else
            {
                lblResul.Content = ("El nuemero no es una escalera " + num1 + " : " + num2);
            }
        }
    }
}
