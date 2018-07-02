using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseListas
{
    class Juego
    {
        private string nombre;
        private int ranking;

        public Juego(string nombre, int ranking)
        {
            this.nombre = nombre;
            this.ranking = ranking;
        }

        public string NOmbre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public int RAnking
        {
            get { return ranking; }
            set { ranking = value; }
        }
        
        public String MostrarDatos()
        {
            return "Nombre :"+nombre+"\nRAnking :"+ranking ;
        }  
    }
}
