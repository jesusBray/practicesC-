using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ClaseListas
{
    class Listas
    {
        List<int> lista;
        Random aleatorio = new Random();
        public List<int> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public Listas(List<int> lista)
        {
            this.lista = lista;
        }
        public List<int> GeneradorListas(int nElementos)
        {
            List<int> listaGenerada = new List<int>();
            for (int i = 0; i < nElementos; i++)
            {
                listaGenerada.Add(aleatorio.Next(1, 100));
            }
            return listaGenerada;
        }
    }
}
