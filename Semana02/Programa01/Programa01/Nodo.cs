using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    public class Nodo
    {
        public int Valor;         // Valor almacenado en el nodo
        public Nodo Siguiente;    // Referencia al siguiente nodo en la lista enlazada

        public Nodo(int valor)
        {
            Valor = valor;       // Inicializa el valor del nodo con el valor proporcionado
            Siguiente = null;    // Inicializa la referencia al siguiente nodo como nula
        }

    }
}
