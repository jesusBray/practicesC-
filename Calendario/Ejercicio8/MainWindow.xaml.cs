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

namespace Ejercicio8
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
        
        public void setCalendario()
        {
            byte datoEntrante = byte.Parse(txtDias.Text), lunes = 1, martes = 2, miercoles = 3, jueves = 4, viernes = 5, sabado = 6, domingo = 7;

            if (datoEntrante>7||datoEntrante<1)
            {
                MessageBox.Show("Solo digite de 1-7 para ver los dias de la semana");
            }
            else
            {
                if (lunes == datoEntrante)
                {
                    MessageBox.Show("El dia es lunes: " + lunes);
                }
                else
                {
                    if (martes == datoEntrante)
                    {
                        MessageBox.Show("El dia es martes: "+martes);    
                    }
                    else
                    {
                        if (miercoles == datoEntrante)
                        {
                            MessageBox.Show("El dia es miercoles: " + miercoles);    
                        }
                        else
                        {
                            if (jueves == datoEntrante)
                            {
                                MessageBox.Show("El dia es jueves: "+jueves);
                            }
                            else
                            {
                                if (viernes == datoEntrante)
                                {
                                    MessageBox.Show("El dia es viernes: " + viernes);    
                                }
                                else
                                {
                                    if (sabado == datoEntrante)
                                    {
                                        MessageBox.Show("El dia es sabado: " + sabado);        
                                    }
                                    else
                                    {
                                        if (domingo == datoEntrante)
                                        {
                                            MessageBox.Show("El dia es domingo: " + domingo);            
                                        }
                                        else
                                        {
                                            MessageBox.Show("no pponga webadas");        
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public string mes(byte mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Frebrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Disiembre";
                default: return "No envie weads";
            }   
        }
        public void clicResult(object sender, RoutedEventArgs e)
        {
            setCalendario();
            MessageBox.Show("El mes es: " + mes(byte.Parse(txtMes.Text))); 
        }
    }
}
