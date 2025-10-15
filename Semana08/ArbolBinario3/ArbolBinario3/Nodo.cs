using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    // Clase Nodo
    public class Nodo
    {
        public Estudiante Datos { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(Estudiante estudiante)
        {
            Datos = estudiante;
            Izquierdo = null;
            Derecho = null;
        }
    }

}
