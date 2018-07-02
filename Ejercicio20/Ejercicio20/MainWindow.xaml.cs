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

namespace Ejercicio20
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int[] arreglo;

        public MainWindow()
        {
            InitializeComponent();   
        }

        private void ClicCrearArreglo(object sender, RoutedEventArgs e)
        {
            int datoEntrante = int.Parse(txtDatosEntrada.Text);
            arreglo = new int[datoEntrante];
        }

        private void ClicLlamarDatos(object sender, RoutedEventArgs e)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = aleatorio.Next();
            }
        }

        public void MostrarDatos()
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                lbxListas.Items.Add(arreglo[i]);
            }
        }

        private void ClicMostrarDatos(object sender, RoutedEventArgs e)
        {
            MostrarDatos();
        }

        private void ClicSumaDeElementos(object sender, RoutedEventArgs e)
        {
            int resp = arreglo[0];
            for (int i = 0; i < arreglo.Length; i++)
            {
                resp=(arreglo[i] + arreglo[i + 1]);
            }

            lbxListas.Items.Add(": "+resp);
           
        }

        //esta funcion incialisa los lementos antes que se ejecule el jPanel;
        private void InitialPanel(object sender, RoutedEventArgs e)
        {
            Random aleatorio = new Random();
            //inicialisamos el arreglo con con la clase Interacction;
            int datosEntrantes = int.Parse(Interaction.InputBox("Ingre sus datos","array"));
            //inicialisamos en arreglo con sus valores;
            arreglo = new int[datosEntrantes];
            //ahora con ayuda de un bucle for inicialisamos cada pocicion ejemplo en la posicion inicalisamos el valor ...
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = aleatorio.Next(1, 100);

            }
            //instanciamos la clase ClaseArray para inicialisar los valores con su contrustor;
            ClaseArray claseArray = new ClaseArray(arreglo);
            MostrarDatos();
        }

        private void ClicMayorQue(object sender, KeyEventArgs e)
        {

            ClaseArray claseArray = new ClaseArray(arreglo);
            
            lbxListas.Items.Add(":" + claseArray.ElementoMayor());
        }

        private void ClicMenorQue(object sender, KeyEventArgs e)
        {
            ClaseArray claseArray = new ClaseArray(arreglo);
            int resultado =claseArray.ElementoMenor();
            lbxListas.Items.Add(":" + resultado);
        }
    }
}
