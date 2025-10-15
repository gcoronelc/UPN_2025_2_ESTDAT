using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario2
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }

    }
}
