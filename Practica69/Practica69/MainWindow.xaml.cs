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

namespace Practica69
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
        Cadenas cadena ;
        private void ClicPalindromo(object sender, RoutedEventArgs e)
        {
            cadena = new Cadenas();
            lbxLista.Items.Add(cadena.palindromo(txtDato.Text));
        }

        private void clicPalabras(object sender, RoutedEventArgs e)
        {
            lbxLista.Items.Clear();
            cadena = new Cadenas();
            lbxLista.Items.Add(cadena.CantidadPalabras(txtDato.Text));
        }

        private void clicBuscarCaracter(object sender, RoutedEventArgs e)
        {
            cadena = new Cadenas();
            char dato = char.Parse(Interaction.InputBox("Digite su caracter ", "Caracteres"));
            if (cadena.BuscarCaracter(dato, txtDato.Text)==true)
            {
                lbxLista.Items.Add("El caracter es existente");
            }
            else
            {
                lbxLista.Items.Add("El caracter no es existente");
            }
        }

        private void ClickLimpiarDAtos(object sender, RoutedEventArgs e)
        {
            txtDato.Text = "";
            lbxLista.Items.Clear();
        }


        private void clicNew(object sender, RoutedEventArgs e)
        {
            new Win().Show();
        }

        private void ClicBuscarNumeros(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            {
                
            }
        }
        
    }
}
