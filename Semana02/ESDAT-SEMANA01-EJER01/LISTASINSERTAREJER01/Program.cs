using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTASINSERTAREJER01
{


    class Nodo
    {
        public int Valor;         // Valor almacenado en el nodo
        public Nodo Siguiente;    // Referencia al siguiente nodo en la lista enlazada

        public Nodo(int valor)
        {
            Valor = valor;       // Inicializa el valor del nodo con el valor proporcionado
            Siguiente = null;    // Inicializa la referencia al siguiente nodo como nula
        }
    }

    class ListaEnlazada
    {
        public Nodo Primero;     // Referencia al primer nodo de la lista

        public ListaEnlazada()
        {
            Primero = null;      // Inicializa la lista enlazada como vacía al principio
        }

        public void InsertarAlInicio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);    // Crea un nuevo nodo con el valor proporcionado
            nuevoNodo.Siguiente = Primero;       // Establece el siguiente del nuevo nodo al actual primero
            Primero = nuevoNodo;                 // Actualiza el primer nodo de la lista
        }

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);    // Crea un nuevo nodo con el valor proporcionado
            if (Primero == null)
            {
                Primero = nuevoNodo;             // Si la lista está vacía, el nuevo nodo es el primero
            }
            else
            {
                Nodo actual = Primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;    // Avanza hasta el último nodo
                }
                actual.Siguiente = nuevoNodo;     // Establece el siguiente del último nodo al nuevo nodo
            }
        }

        public void InsertarEnPosicion(int valor, int posicion)
        {
            if (posicion <= 0)
            {
                InsertarAlInicio(valor);         // Inserta al inicio si la posición es no válida o negativa
            }
            else
            {
                Nodo nuevoNodo = new Nodo(valor);
                Nodo actual = Primero;
                for (int i = 1; i < posicion && actual != null; i++)
                {
                    actual = actual.Siguiente;    // Avanza hasta la posición deseada o hasta el final de la lista
                }
                if (actual != null)
                {
                    nuevoNodo.Siguiente = actual.Siguiente;    // Conecta el nuevo nodo con el siguiente nodo
                    actual.Siguiente = nuevoNodo;              // Conecta el nodo actual con el nuevo nodo
                }
                else
                {
                    Console.WriteLine("Posición no válida.");
                }
            }
        }

        public void Mostrar()
        {
            Nodo actual = Primero;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");   // Imprime el valor del nodo actual
                actual = actual.Siguiente;           // Avanza al siguiente nodo
            }
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            ListaEnlazada lista = new ListaEnlazada();   // Crea una instancia de la lista enlazada

            while (true)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Insertar al inicio");
                Console.WriteLine("2. Insertar al final");
                Console.WriteLine("3. Insertar en una determinada posición");
                Console.WriteLine("4. Mostrar");
                Console.WriteLine("5. Salir");
                Console.Write("ESCOJA UNA OPCION: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un valor: ");
                        int valorInicio = int.Parse(Console.ReadLine());
                        lista.InsertarAlInicio(valorInicio);   // Inserta el valor al inicio de la lista
                        break;

                    case 2:
                        Console.Write("Ingrese un valor: ");
                        int valorFinal = int.Parse(Console.ReadLine());
                        lista.InsertarAlFinal(valorFinal);     // Inserta el valor al final de la lista
                        break;

                    case 3:
                        Console.Write("Ingrese un valor: ");
                        int valorPosicion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la posición: ");
                        int posicion = int.Parse(Console.ReadLine());
                        lista.InsertarEnPosicion(valorPosicion, posicion);  // Inserta el valor en la posición indicada
                        break;

                    case 4:
                        lista.Mostrar();    // Muestra los valores de la lista
                        break;

                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
