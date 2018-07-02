using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class ClaseArray
    {
        private int[] dato;
        private string nombre;

        public ClaseArray(int[] dato){
            this.dato=dato;
        }
        
        public ClaseArray(int[] dato,string nombre){
            this.dato=dato;
            this.nombre=nombre;
        }

        public int SumaElementos()
        {
            int resp = 0;
            for (int i = 0; i < dato.Length; i++)
            {
                resp =+ dato[i];
            }
            return resp;
        }

        public int[] Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }
        public int ElementoMayor(){
            int resp = dato[0];
            for (int i = 1; i <=dato.Length; i++)
            {
                if (dato[i] > resp)
                {
                    resp = dato[i];
                }
            }
            return resp;
        }
        public void MetodoBurbu(int entradaDatos){
            int resultado;
            for (int i = 0; i < dato.Length; i++)
			{
                resultado=dato[i] = entradaDatos;   
			}
        }
        public int ElementoMenor()
        {
            int resp = dato[0];
            for (int i = 0; i < dato.Length; i++)
            {
                if (dato[i] < resp)
                {
                    resp = dato[i];
                }
            }
            return resp;
        }

        public double Promedio()
        {
            int resp=dato[0],totalSuma=0;
            for (int i = 0; i < dato.Length; i++)
            {
                totalSuma =+ dato[i];
            }
            return resp/totalSuma;
        }
    }
}
