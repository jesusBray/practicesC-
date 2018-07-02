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

namespace Ejercicio15
{
    public partial class MainWindow : Window
    {
        //Variables glovales
        double num1, num2, num3, num4, resultado, resultadoFinal;
        Random aleatorio = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClicRespEjer1(object sender, RoutedEventArgs e)
        {
            //Se ingresa un dato en la cual se verifica si esta en el rango de 10 a 100;
            num1=double.Parse(txtEjer1Datos1.Text);
            if(num1>=10 && num1<=100){
                MessageBox.Show("Esta es el rango de 10-100 \nEl numero: "+num1);
            }
            else
            {
                MessageBox.Show("No esta es el rango de 10-100 \nEl numero:  " + num1);
            }
        }

        private void ClicRespEjer2(object sender, RoutedEventArgs e)
        {
            //Se utiliza un valor randomico y se verifica si este es par o inpar;
            num1 = aleatorio.Next(1,7);
            lblRespEjer2Dado1.Content =(num1);
            if(num1 % 2 ==0){
                lblRespEjer2.Content = ("El resultado es Par: " + num1);
            }
            else
            {
                lblRespEjer2.Content = ("El resultado no es Par: " + num1);
            }
        }

        private void ClicRespEjer3(object sender, RoutedEventArgs e)
        {
            //Se utilisan 2 numeros randomicos para ver la provabilidad si son pares,si lo son se suman ambos valores y se verifica si son pares;
            num1 = aleatorio.Next(1, 7);
            num2 = aleatorio.Next(1, 7);
            lblRespEjer3Dado1.Content=num1;
            lblRespEjer3Dado2.Content = num2;
            resultado = num1+num2;
            if(resultado%2==0){
                MessageBox.Show("Felisidades Sacaste Pares  \nLa sumatoria de los 2 dados es: "+resultado);
            }
            else
            {
                MessageBox.Show("Perdedor no salio nada" + resultado);
            }
        }

        private void clicRespEjer4(object sender, RoutedEventArgs e)
        {
            //Se dan 3 digitos en el cual interviene la potencia, la raiz cuadrada,
            //Es representada con la formula con 2 resultados definida por 3 variables a=num1, b=num2, c=num3;
            num1 = double.Parse(txtEjer4Datos1.Text);
            num2 = double.Parse(txtEjer4Datos2.Text);
            num3 = double.Parse(txtEjer4Datos3.Text);
            //Furmula en la siguiente columna;
            //Ecuacion de segundo grado
            resultado = (num2 - Math.Sqrt(Math.Pow(num2, 2)-(4 * (num1 * num3)))) / (2 * num1);
            resultadoFinal = (num2 + Math.Sqrt(Math.Pow(num2, 2) - (4 * (num1 * num3)))) / (2 * num1);
            if(resultado >0&&resultadoFinal>0){
                MessageBox.Show("El resultado para positivo es:\nResp: " + resultadoFinal+"\n"+"El resultado para negativo es:\nResp: " + resultado);
            }
            else
            {
                MessageBox.Show("Datos no validos ");
            }
        }

        private void ClicRespEjer5(object sender, RoutedEventArgs e)
        {
            //Datos ingresados 4 en la cual busca al digito menor y se suma los 3 restantes el resultado es dividio entre 3
            num1 = double.Parse(txtEjer5Datos1.Text);
            num2 = double.Parse(txtEjer5Datos2.Text);
            num3 = double.Parse(txtEjer5Datos3.Text);
            num4 = double.Parse(txtEjer5Datos4.Text);

            if(num1<=num2&&num2<=num3&&num3<=num4||num1<=num2&&num1<=num3&&num1<=num4){

                resultado = (num2 + num3 + num4)/3;
                MessageBox.Show("La sumatoria es: " + (num2 + num3 + num4)+"\nLa nota oviada es: "+num1+"\nEl resultado final es: "+ resultado);
            }
            if (num2 <= num1 && num1 <= num3 && num3 <= num4 || num2 <= num1 && num2 <= num3 && num2 <= num4)
            {
                resultado = (num1 + num3 + num4) / 3;
                MessageBox.Show("La sumatoria es: " + (num1 + num3 + num4) + "\nLa nota oviada es: " + num2 + "\nEl resultado final es: " + resultado);
            }
            if (num3 <= num1 && num1 <= num2 && num2 <= num4 || num3 <= num1 && num3 <= num2 && num3 <= num4)
            {
                resultado = (num1 + num2 + num4) / 3;
                MessageBox.Show("La sumatoria es: " + (num1 + num2 + num4) + "\nLa nota oviada es: " + num3 + "\nEl resultado final es: " + resultado);
            }
            if (num4 <= num1 && num1 <= num2 && num2 <= num3 || num4 <= num1 && num4 <= num2 && num4 <= num3)
            {
                resultado = (num4 + num1 + num2) / 3;
                MessageBox.Show("La sumatoria es: " + (num1 + num2 + num3) + "\nLa nota oviada es: " + num4 + "\nEl resultado final es: " + resultado);
            }
         
        }

        private void ClicRespEjer6(object sender, RoutedEventArgs e)
        {
           //Para este ejercicio se utilisara la clase random con 2 unicos resultados. 1 equibale a cara
           num1 = aleatorio.Next(1, 3);
           if(num1 == 1){
               MessageBox.Show("Que suerte! Ganaste salio cara");
           }
           else
           {
               MessageBox.Show("Mala suerte Perdiste ");
           }

        }

        private void ClicRespEjer6_2(object sender, RoutedEventArgs e)
        {
            //Para este ejercicio se utilisara la clase random con 2 unicos resultados. 2 equibale a cruz
            num1 = aleatorio.Next(1, 3);
            if (num1 == 2)
            {
                MessageBox.Show("Que suerte! Ganaste salio cruz");
            }
            else
            {
                MessageBox.Show("Mala suerte Perdiste ");
            }
        }

        private void clicInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(":Abierto 24/7\n :En tu cumple no pasa nada: presente su ci\n :Martinis para damas descuentos del 50% \n :Reserva de mesas por adelantado");
        }
    }
}
