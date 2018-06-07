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

namespace Ejercicio9
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

        private void clicResultado(object sender, ContextMenuEventArgs e)
        {
           
        }

        private void clicResultado(object sender, RoutedEventArgs e)
        {
            double num1, num2, num3;
            num1 = double.Parse(txtDato1.Text);
            num2 = double.Parse(txtDato2.Text);
            num3 = double.Parse(txtDato3.Text);

            if ((num1 >= num2) && (num1 >= num3))
            {
                MessageBox.Show("Si es un triangulo exacto dado que tiene lados iguales: " + num1);
            }
            else{
                MessageBox.Show("No es un triangulo Exacto");
            }
            if ((num2>= num1)&& (num2>= num3))
            {
                MessageBox.Show("Si es un triangulo exacto dado que tiene lados iguales: " + num1);

            }    
            else{
                MessageBox.Show("No es un triangulo Exacto");
            }
            if ((num3 >= num1) && (num3 >= num2))
            {
                MessageBox.Show("Si es un triangulo exacto dado que tiene lados iguales: " + num1);

            }
            else
            {
                MessageBox.Show("No es un triangulo Exacto");
            }
        }
    }
}
