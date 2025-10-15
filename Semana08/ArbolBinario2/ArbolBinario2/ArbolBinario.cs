using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario2
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; private set; }

        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método para agregar un nodo
        public void Agregar(int valor)
        {
            Raiz = AgregarRecursivo(Raiz, valor);
            Console.WriteLine($"Valor {valor} agregado correctamente.");
        }

        private Nodo AgregarRecursivo(Nodo nodo, int valor)
        {
            // Si el nodo es null, crear un nuevo nodo
            if (nodo == null)
            {
                return new Nodo(valor);
            }

            // Si el valor es menor, ir al subárbol izquierdo
            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = AgregarRecursivo(nodo.Izquierdo, valor);
            }
            // Si el valor es mayor, ir al subárbol derecho
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = AgregarRecursivo(nodo.Derecho, valor);
            }
            // Si el valor ya existe, no hacer nada (evitar duplicados)

            return nodo;
        }

        // Método para buscar un elemento
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(Raiz, valor);
        }

        private bool BuscarRecursivo(Nodo nodo, int valor)
        {
            // Si el nodo es null, el valor no existe
            if (nodo == null)
            {
                return false;
            }

            // Si encontramos el valor
            if (valor == nodo.Valor)
            {
                return true;
            }

            // Buscar en el subárbol correspondiente
            if (valor < nodo.Valor)
            {
                return BuscarRecursivo(nodo.Izquierdo, valor);
            }
            else
            {
                return BuscarRecursivo(nodo.Derecho, valor);
            }
        }

        // Método para imprimir el árbol (Recorrido In-Orden)
        public void ImprimirInOrden()
        {
            Console.Write("Recorrido In-Orden: ");
            ImprimirInOrdenRecursivo(Raiz);
            Console.WriteLine();
        }

        private void ImprimirInOrdenRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                ImprimirInOrdenRecursivo(nodo.Izquierdo);
                Console.Write(nodo.Valor + " ");
                ImprimirInOrdenRecursivo(nodo.Derecho);
            }
        }

        // Método para imprimir el árbol (Recorrido Pre-Orden)
        public void ImprimirPreOrden()
        {
            Console.Write("Recorrido Pre-Orden: ");
            ImprimirPreOrdenRecursivo(Raiz);
            Console.WriteLine();
        }

        private void ImprimirPreOrdenRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.Write(nodo.Valor + " ");
                ImprimirPreOrdenRecursivo(nodo.Izquierdo);
                ImprimirPreOrdenRecursivo(nodo.Derecho);
            }
        }

        // Método para imprimir el árbol (Recorrido Post-Orden)
        public void ImprimirPostOrden()
        {
            Console.Write("Recorrido Post-Orden: ");
            ImprimirPostOrdenRecursivo(Raiz);
            Console.WriteLine();
        }

        private void ImprimirPostOrdenRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                ImprimirPostOrdenRecursivo(nodo.Izquierdo);
                ImprimirPostOrdenRecursivo(nodo.Derecho);
                Console.Write(nodo.Valor + " ");
            }
        }

        // Método para imprimir el árbol de forma visual
        public void ImprimirArbol()
        {
            Console.WriteLine("\nEstructura del árbol:");
            ImprimirArbolRecursivo(Raiz, "", true);
        }

        private void ImprimirArbolRecursivo(Nodo nodo, string indent, bool ultimo)
        {
            if (nodo != null)
            {
                Console.Write(indent);
                if (ultimo)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "│ ";
                }
                Console.WriteLine(nodo.Valor);

                ImprimirArbolRecursivo(nodo.Izquierdo, indent, false);
                ImprimirArbolRecursivo(nodo.Derecho, indent, true);
            }
        }
    }
}
