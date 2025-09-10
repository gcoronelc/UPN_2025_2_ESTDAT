using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaSimple
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string Nombre)
        {
            this.Nombre = Nombre;
            this.Siguiente = null;
        }

       
    }
}
