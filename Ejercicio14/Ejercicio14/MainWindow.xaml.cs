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

namespace Ejercicio14
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int menor, medio, mayor,d1,d2,d3;
        Random aleatorio = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClic(object sender, RoutedEventArgs e)
        {

            d1 = aleatorio.Next(1, 2);
            d2 = aleatorio.Next(1, 7);
            d3 = aleatorio.Next(1, 7);

            lblDato1.Content = d1;
            lblDato2.Content = d2;
            lblDato3.Content = d3;

            if(d1 >= d2 && d1 >= d3){
                mayor = d1;
                if(d2 >= d3){
                    medio = d2;
                    menor = d3;

                }
                else
                {
                    medio = d3;
                    menor = d2;
                }
            }
            else
            {
                if(d2>=d3){
                    mayor = d2;
                    if(d1>=d3){
                        medio = d1;
                        menor = d3;
                    }
                    else
                    {
                        medio = d3;
                        menor = d2;
                    }
                }
                else
                {
                    mayor = d3;
                    if(d1>=d3){
                        medio = d1;
                        menor = d1;
                    }
                    else
                    {
                        medio = d3;
                        menor = d1;

                    }
                }
            }
        }
    }
}
