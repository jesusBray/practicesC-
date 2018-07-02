using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_5
{
    class Tortuga
    {
        private int idPersonaje;
        private int direccion_Inicial;
        private string color;
        private double pocicion;
        private bool alas;
        private int nivel_Vida;
        private bool vivo;
        private double posicio_Final;
        private string color_Caparason;
        private string color_Muerto;

        public Tortuga(int x,int y,string z,double a,bool b, int c)
        {
            this.idPersonaje = x;
            this.direccion_Inicial = y;
            this.color = z;
            this.pocicion = a;
            this.alas = b;
            this.nivel_Vida = c;
            //this.vivo = d;
        }



        public Tortuga(int idPersonaje, int direccion_Inicial, double pocicio_Final)
        {
            this.idPersonaje = idPersonaje;
            this.direccion_Inicial = direccion_Inicial;
            this.posicio_Final = pocicio_Final;
        }

        

        public Tortuga(string color, string color_Caparason, string color_Muerto){
            this.color=color;
            this.color_Caparason=color_Caparason;
            this.color_Muerto = color_Muerto;
        }

        public string Color_Muerto{
            get
            {
                return color_Muerto;
            }
            set
            {
                color_Muerto = value;
            }
        }

        public string datos_esteticos()
        {
            string return_Estetico = "Colores caracteristicos de la Tortuga: "+color+"\nColor de caparazon: "+color_Caparason+"\nColor de una tortuga muerta"+color_Muerto;
            return return_Estetico;
        }
        public int Nivel_Vida 
        {
            get
            {
                return nivel_Vida;
            }
            set
            {
                if (nivel_Vida >0 && nivel_Vida <100)
                {
                    nivel_Vida = value;
                }
            }
        }
        

        public string informacion(){
            string dato;
            if (vivo ==true)
            {
                dato = "Datos:" + idPersonaje + "\nDireccion Inicial: " + direccion_Inicial + "\nColor: " + color + alas + "\nVida: " + nivel_Vida;
            }
            else
            {
                dato ="tortuga muerta";
    	    }
            return dato;
        }

    }
}
