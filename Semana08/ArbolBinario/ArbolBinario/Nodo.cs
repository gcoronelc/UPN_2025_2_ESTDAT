using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }


        public Nodo(int dato)
        {
            this.Dato = dato;
            this.Izquierda = null;
            this.Derecha = null;
        }

    }
}
