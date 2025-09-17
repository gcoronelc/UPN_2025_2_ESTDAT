using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;    // El siguiente nodo inicialmente es null
        }

    }
}
