using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEjemplo
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo Anterior { get; set; }

        // Constructor
        public Nodo(string Nombre, int Nota)
        {
            this.Nombre = Nombre;
            this.Nota = Nota;
            this.Siguiente = null;
            this.Anterior = null;
        }

    }
}
