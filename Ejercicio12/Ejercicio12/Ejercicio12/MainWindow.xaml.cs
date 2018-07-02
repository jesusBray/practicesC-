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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1,num2,num3, result;
        Random aleatorio = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClicResultado2(object sender, RoutedEventArgs e)
        {
            num1 = aleatorio.Next(1, 7);
            num2 = aleatorio.Next(1, 7);
            lblDado1.Content = num1;
            lblDado1.Content = num2;
            if(num1>(num2-1)&&num2>(num1-1)){
                lblResultado1.Content = "Ganaste Salio escalera";
            }
            else
            {
                lblResultado1.Content = "Perdedor no Salio escalera";
            }
        }

        private void clicResultado1(object sender, ContextMenuEventArgs e)
        {
            num1 = aleatorio.Next(1,7);
            num2 = aleatorio.Next(1,7);
            num3 = aleatorio.Next(1,7);
            lblResp1.Content = num1;
            lblResp2.Content = num2;
            lblResp3.Content = num3;
            if (num1 > (num2 - 1)&&num1>(num3-1)||num2>(num1-1)&&num2>(num3-1)||num3>(num1-1)&&num3>(num2-1))
            {
                lblResultado2.Content = "Ganaste Sacaste Escalera de 3 dados";
            }
            else
            {
                lblResultado2.Content = "Perdedor no Sacaste Escalera de 3 dados";
            }
        }
    }
}
