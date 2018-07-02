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

namespace Ejercicio12Calculadora
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
        
        public double entradaDatos()
        {
            double num1 = double.Parse(txtDato1.Text),num2 = double.Parse(txtDato2.Text),result = 0;
            char caracter = char.Parse(txtSigno.Text);
            char suma = '+';
            char resta = '-';
            char multiplicacion = '*';
            char divicion = '/';
            
            if(caracter == suma){
                result = num1 + num2;
            }
            
            else
            {
                if (caracter == resta)
                {
                    result = num1 - num2;
                }
                else
                {
                    if (caracter == multiplicacion)
                    {
                        result = num1 * num2;
                    }
                    else
                    {
                        if (caracter == divicion)
                        {
                            if (num1 == 0||num2==0)
                            {
                                result = 0;
                            }
                            else{
                                result = num1 / num2;
                            }
                            
                        }
                        else
                        {
                            if (true)
                            {
                                
                            }
                        }
                    }
                }
            }
            return result;

        }

        private void clicResult(object sender, RoutedEventArgs e)
        {
            lbxLista.Items.Add(entradaDatos());
        }

        private void ClicClear(object sender, RoutedEventArgs e)
        {
            lbxLista.Items.Clear();
            txtDato1.Clear();
            txtSigno.Clear();
            txtDato2.Clear();
        }

    }
}
