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
using System.Windows.Shapes;

namespace ClaseListas
{
    /// <summary>
    /// Lógica de interacción para Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        public Win()
        {
            InitializeComponent();
        }
        Juego juego;
        List<Juego> listGane;
        List<int> lista = new List<>();

        public void MostrarDAtos()
        {
              
        }

        private void ClicResivirDatos(object sender, RoutedEventArgs e)
        {
            //esta lsita es para enlasar una ventana de otra asi para tener mas dinamismo 

            juego = new Juego(txtNombre.Text,int.Parse(txtRanking.Text));

            
        }
    }
}
