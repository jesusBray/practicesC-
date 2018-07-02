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

namespace Ejercicio17
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1, num2, num3, num4, result, result2, result3, result4, resultadoFinal;
        Random aleatorio = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejer1Clic(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(lbl1.Text);
            if (num1 >= 10 && num1 >= 100)
            {
                MessageBox.Show("Si esta en el rango de 10 - 100"+num1);
            }
            else
            {
                MessageBox.Show("No esta en el rango de 10 - 100" + num1);
            }
        }

        private void ClicEjer2_6(object sender, RoutedEventArgs e)
        {
            
            num1 = aleatorio.Next(1,7);
            num2 = aleatorio.Next(1,7);
            lblEjercicio2.Content=(num1);
            lblEjercicio3.Content = (num2);
            if (num1 % 2 ==0)
            {
                MessageBox.Show("El sesultado es Par" + num1);
            }
            else
            {
                MessageBox.Show("El sesultado no es Par" + num1);
            }

            if (num1 % 2 == 0 && num1 % 2 == 0)
            {
                MessageBox.Show("El sesultado es Par" + num1);
            }
            else
            {
                MessageBox.Show("El sesultado no es Par" + num1);
            }
            
        }

        private void ClicEjer5(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(lblEjer5Dato1.Text);
            num2 = double.Parse(lblEjer5Dato2.Text);
            num3 = double.Parse(lblEjer5Dato3.Text);
            num4 = double.Parse(lblEjer5Dato4.Text);

            if(num1<=num2&&num2<=num3&&num3<=num4){
                result = (num2 + num3 + num4)/3;

                MessageBox.Show("El dato obiado es" + num1+"/nLa suma general es: "+result);
            }
            if (num2 <= num1 && num1 <= num3 && num3 <= num4)
            {
                result2 = (num1 + num3 + num4) / 3;

                MessageBox.Show("El dato obiado es" + num2 + "/nLa suma general es: " + result2);
            }
            if (num3 <= num1 && num1 <= num2 && num2 <= num4)
            {
                result3 = (num2 + num1 + num4) / 3;

                MessageBox.Show("El dato obiado es" + num3 + "/nLa suma general es: " + result3);
            }
            if (num4 <= num1 && num1 <= num2 && num2 <= num3)
            {
                result4 = (num1 + num2 + num3) / 3;

                MessageBox.Show("El dato obiado es" + num1 + "n");
            }
        }

        private void lblEjer2(object sender, ContextMenuEventArgs e)
        {

        }

        private void ClicResultado(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(lblEjer4Dato1.Text);
            num2 = double.Parse(lblEjer4Dato2.Text);
            num3 = double.Parse(lblEjer4Dato3.Text);
            result =(-num2)+(Math.Sqrt(Math.Pow(num2,2)-(4*(num1*num3))))/(2*num1);
            resultadoFinal = (-num2) - (Math.Sqrt(Math.Pow(num2, 2) - (4 * (num1 * num3)))) / (2 * num1);
            MessageBox.Show("Resp: 1" + result+"/nResp 2: "+resultadoFinal);
        }
    }
}
