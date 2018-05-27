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
namespace Ejercicio21
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

        int[] array;
        ClassArray1 vect;

        private void Inicial(object sender, RoutedEventArgs e)
        {
            Random aleatorio = new Random();
            int numeroElementos = int.Parse(Interaction.InputBox("Ingrese el numero de indices que tendra el array", "Array Aplication"));

            array = new int[numeroElementos];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = aleatorio.Next(1,100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                lbxLista.Items.Add(array[i]);
            }

        }
        private void ClicSumaElementos(object sender, RoutedEventArgs e)
        {
            vect = new ClassArray1(array);
            lbxLista.Items.Add(vect.SumaArreglo());
        }

        private void ClicMayorElemento(object sender, RoutedEventArgs e)
        {
            vect = new ClassArray1(array);
            lbxLista.Items.Add(vect.MayorQue());
        }

        private void ClicMenorElemento(object sender, RoutedEventArgs e)
        {
            vect = new ClassArray1(array);
            lbxLista.Items.Add(vect.MenorQue());
        }

        private void ClicMediaElementos(object sender, RoutedEventArgs e)
        {
            ClassArray1 vect = new ClassArray1(array);
            lbxLista.Items.Add(vect.MediaElementos());
        }

        private void clicBorrar(object sender, RoutedEventArgs e)
        {
            lbxLista.Items.Clear();
        }
    }
}
