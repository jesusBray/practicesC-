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

namespace EjercicioRecuperatorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clicDados(object sender, RoutedEventArgs e)
        {
            double num1, num2, num3, num4, num5;
            Random aleatorio = new Random();
            aleatorio.Next(1,7);
            num1 = aleatorio.Next(1,7);
            num2 = aleatorio.Next(1,7);
            num3 = aleatorio.Next(1,7);
            num4 = aleatorio.Next(1,7);
            num5 = aleatorio.Next(1,7);
            lblDad1.Content = num1;
            lblDad2.Content = num2;
            lblDad3.Content = num3;
            lblDad4.Content = num4;
            lblDad5.Content = num5;

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                lblDadoNum1.Content = "Es una escalera!!!";
            }
            else
            {
                lblDadoNum1.Content = "No es una escalera!!!";
            }
            if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                lblDadoNum1.Content = "Es una escalera!!!";
            }
            else
            {
                lblDadoNum1.Content = "No es una escalera!!!";
            }
            if(num3>num1&&num3>num2&&num3>num4&&num3>num5)
            {
                lblDadoNum1.Content = "Es una escalera!!!";
            }
            else
            {
                lblDadoNum1.Content = "No es una escalera!!!";
            }
            if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                lblDadoNum1.Content = "Es una escalera!!!";
            }
            else
            {
                lblDadoNum1.Content = "No es una escalera!!!";
            }
            if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            {
                lblDadoNum1.Content = "Es una escalera!!!";
            }
            else
            {
                lblDadoNum1.Content = "No es una escalera!!!";
            }
        }
    }
}
