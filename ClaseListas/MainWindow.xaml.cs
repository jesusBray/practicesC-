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
using Microsoft.VisualBasic;

namespace ClaseListas
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbnButton_Click(object sender, RoutedEventArgs e)
        {
            List<double> numeros = new List<double>();
            Random aleatorio = new Random();
            
            double nElementos = double.Parse(Interaction.InputBox("Digite el numero de elementos ", "Lista Dinamica..."));
            
            for (int i = 0; i < nElementos; i++)
            {
                numeros.Add(aleatorio.Next(1,20));
            }

            lbxLista.Items.Clear();
            //Count obtiene el numero de elemtos
            for (int i = 0; i < numeros.Count; i++)
            {
               
                lbxLista.Items.Add("Nº"+(i+1)+" "+numeros[i]);
                
            }
            double sumaElementos = 0, numMayor = 0;
           // foreach (double item in numeros)
            //{
                   
               // lbxLista.Items.Add("Nº"+item);
            //}

            lbxLista.Items.Add("El mayor es " + numeros.Max());
            lbxLista.Items.Add("El mayor es " + numeros.Min());
            lbxLista.Items.Add("El mayor es " + numeros.Sum());
            lbxLista.Items.Add("El mayor es " + numeros.Average());

            //este metodo ordena la lista
            lbxLista.Items.Add("lista ordenada");
            foreach (var item in numeros)
            {
                lbxLista.Items.Add(item);
            }
        }

        private void btnGenerarLista_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Win ventana = new Win();
            ventana.Show();
        }
    }
}
