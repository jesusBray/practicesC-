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

namespace Ejercicio2_5
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Tortuga tortuga = new Tortuga(123,1,"rojo",0.1,true,100);
        Tortuga pocicio_Tortuga = new Tortuga(123,0,0);
        Tortuga color_Tortuga = new Tortuga("naranjado","verde","negro");
        Jugador datosgenerale = new Jugador("Digite su nombre","Digite su apellido",0,"Masculino",10.00,"Digite su alias");
        Jugador datosPersonales = new Jugador("", "", 0, "");
        Jugador datosDeJuego = new Jugador("",0,"");
        

        private void Onclic(object sender, RoutedEventArgs e)
        {
            //tortuga.Nivel_Vida(12);
            //lblDatos.Content=(tortuga.Nivel_Vida());
            //lblDatos.Content = (tortuga.informacion());
        }

        private void onClic2(object sender, RoutedEventArgs e)
        {
            
        }

        private void onClic3(object sender, RoutedEventArgs e)
        {
            lblDatos2.Content = (color_Tortuga.datos_esteticos());
        }

        private void ClicDatoJugador(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(datosgenerale.VerInfo());
        }
        
    }
}
