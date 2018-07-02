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

namespace Ejercicio
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

        private double Mayor2(double a, double b)
        {           
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        
        }


        private double Mayor3(double a, double b, double c)
        {

            //double res;
            //double x = Mayor2(a,b);
            //res = Mayor2(x,c);
            //return res;
      
            return Mayor2(Mayor2(a, b), c);
        
        }


        private double Mayor4(double a, double b, double c, double d)
        {
            //double res;
            //double x = Mayor3(a,b,c);            
            //res = Mayor2(x,d);
            //return res;        
      
            return Mayor2(Mayor3(a, b, c), d);        

        }

        private double Mayor5(double a, double b, double c, double d, double e)
        {
            //double res;
            //double x = Mayor4(a,b,c,d);
            //res = Mayor2(x, e);
            //return res;
            
            return Mayor2(Mayor4(a, b, c, d), e);

        }


        private double Mayor6(double a, double b, double c, double d, double e, double f)
        {
            //double res;
            //double x = Mayor3(a,b,c);
            //double y = Mayor3(d,e,f);
            //res = Mayor2(x,y);
            //return res;        
            
            return Mayor2(Mayor3(a, b, c), Mayor3(d, e, f));       

        }

        private void btnMayor2_Click(object sender, RoutedEventArgs e)
        {

            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);

            lblResultado.Content = "El Mayor es: " + Mayor2(n1,n2);

        }

        private void btnMayor3_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);

            lblResultado.Content = "El Mayor es: " + Mayor3(n1, n2, n3);
        }

        private void btnMayor4_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);
            double n4 = double.Parse(txtN4.Text);

            lblResultado.Content = "El Mayor es: " + Mayor4(n1, n2, n3, n4);
        }

        private void btnMayor5_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);
            double n4 = double.Parse(txtN4.Text);
            double n5 = double.Parse(txtN5.Text);

            lblResultado.Content = "El Mayor es: " + Mayor5(n1, n2, n3, n4, n5);
        }

        private void btnMayor6_Click(object sender, RoutedEventArgs e)
        {
            
                double n1 = double.Parse(txtN1.Text);
                double n2 = double.Parse(txtN2.Text);
                double n3 = double.Parse(txtN3.Text);
                double n4 = double.Parse(txtN4.Text);
                double n5 = double.Parse(txtN5.Text);
                double n6 = double.Parse(txtN6.Text);

                lblResultado.Content = "El Mayor es: " + Mayor6(n1, n2, n3, n4, n5, n6);
            
            

        }



    }
}
