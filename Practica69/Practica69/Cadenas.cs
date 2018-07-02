using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica69
{
    class Cadenas
    {
        public string palindromo(string dato)
        {
            string mensaje = "";
            for (int i = dato.Length; i > 1; i--)
            {
                mensaje = mensaje + dato[i-1];
                if (dato.Equals(mensaje))
                {
                    return "Es un palindromo";
                }   
            }
            return "No es un palindromo";
        }

        public int CantidadPalabras(string dato)
        {
            char espacio = ' ';
            int contador = 0;
            for (int i = 0; i < dato.Length; i++)
            {
                if (dato[i].Equals(espacio))
                {
                    contador ++;
                }
            }
            return (contador+1);
        }
        public bool BuscarCaracter(char caracter,string cadena)
        {
            bool resultado= false;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i]==caracter)
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
        public bool CaracterNumber(char c,string dato)
        {
            bool resultado = false;
            for (int i = 0; i < dato.Length; i++)
            {
                if (char.IsNumber(dato[i])==true)
                {
                resultado = true;
                break;
                }
            }
            return resultado;
        }
    }
}
