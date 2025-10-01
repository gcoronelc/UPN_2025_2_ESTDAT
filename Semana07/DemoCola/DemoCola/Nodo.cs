using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCola
{
   public  class Nodo
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo()
        {
            this.Siguiente = null;
            this.Nombre = "Mathias";
            this.Nota = 100000;
        }
        public Nodo(string nombre, int nota)
        {
            this.Nombre = nombre;
            this.Nota = nota;
            this.Siguiente = null;
        }
    }
}
