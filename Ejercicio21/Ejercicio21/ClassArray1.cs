using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class ClassArray1
    {
        int[] vec;

        public ClassArray1(int[] vec)
        {
            this.vec = vec;
        }

        public ClassArray1(){}

        public int SumaArreglo()
        {
            int suma=0;
            for (int i = 0; i < vec.Length; i++)
            {
                suma = suma + vec[i];
            }
            return suma;
        }

        public int MayorQue()
        {
            int aux = vec[0];
            for (int i = 1; i < vec.Length; i++)
            {
                 if (aux<vec[i])
                {
                    aux = vec[i];
                }
            }
            return aux;
        }

        public int MenorQue()
        {
            int aux = vec[0];
            for (int i = 1; i < vec.Length; i++)
            {
                if (aux > vec[i])
                {
                    aux = vec[i];
                }
            }
            return aux;
        }

        public double MediaElementos()
        {
            int media = vec[0];
            for (int i = 0; i < vec.Length; i++)
            {
                if (media<vec[i])
                {
                    media = i;
                }
            }
            
            return SumaArreglo()/vec.Length;
        }

    }
}
