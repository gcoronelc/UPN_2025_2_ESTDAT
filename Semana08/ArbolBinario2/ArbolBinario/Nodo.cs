using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Nodo
    {
        public string estudiante {  get; set; }
        public int nota {  get; set; }
        public Nodo derecha { get; set; }
        public Nodo izquierda { get; set; }
        public Nodo padre {  get; set; }


        public Nodo(string estudiante, int nota)
        {
            this.estudiante = estudiante;
            this.nota = nota;
            this.derecha = null;
            this.izquierda = null;
            this.padre = null;
        }

        

    }
}
