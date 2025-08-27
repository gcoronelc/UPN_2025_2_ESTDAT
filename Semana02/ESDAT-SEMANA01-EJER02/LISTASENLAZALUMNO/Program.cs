using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTASENLAZALUMNO
{
    class Program
    {
        class Nodo
        {
            public int Edad;         // Edad almacenada en el nodo
            public Nodo Siguiente;  // Referencia al siguiente nodo en la lista enlazada

            public Nodo(int edad)
            {
                Edad = edad;        // Inicializa la edad del nodo con la edad proporcionada
                Siguiente = null;   // Inicializa la referencia al siguiente nodo como nula
            }
        }

        class EdadesManager
        {
            private List<Nodo> listaEdades = new List<Nodo>();   // Lista de nodos para manejar las edades

            public void Insertar(int edad)
            {
                Nodo nuevoNodo = new Nodo(edad);    // Crea un nuevo nodo con la edad proporcionada
                listaEdades.Add(nuevoNodo);         // Agrega el nuevo nodo a la lista de edades
                Console.WriteLine("Edad insertada correctamente.");
            }

            public void Mostrar()
            {
                Console.WriteLine("Lista de edades:");
                foreach (Nodo nodo in listaEdades)
                {
                    Console.Write(nodo.Edad + " ");  // Imprime la edad del nodo actual
                }
                Console.WriteLine();
            }

            public void EliminarPrimeraPosicion()
            {
                if (listaEdades.Count > 0)
                {
                    listaEdades.RemoveAt(0);        // Elimina el primer nodo de la lista
                    Console.WriteLine("Edad en la primera posición eliminada.");
                }
                else
                {
                    Console.WriteLine("La lista de edades está vacía.");
                }
            }

            public void EliminarUltimaPosicion()
            {
                if (listaEdades.Count > 0)
                {
                    listaEdades.RemoveAt(listaEdades.Count - 1);   // Elimina el último nodo de la lista
                    Console.WriteLine("Edad en la última posición eliminada.");
                }
                else
                {
                    Console.WriteLine("La lista de edades está vacía.");
                }
            }

            public void EliminarPosicionIntermedia(int posicion)
            {
                if (posicion >= 0 && posicion < listaEdades.Count)
                {
                    listaEdades.RemoveAt(posicion);   // Elimina el nodo en la posición indicada
                    Console.WriteLine("Edad en la posición intermedia eliminada.");
                }
                else
                {
                    Console.WriteLine("Posición no válida.");
                }
            }
        }

        static void Main(string[] args)
        {
            EdadesManager manager = new EdadesManager();   // Crea una instancia del manejador de edades

            while (true)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. INSERTAR");
                Console.WriteLine("2. MOSTRAR");
                Console.WriteLine("3. ELIMINAR PRIMERA POSICION");
                Console.WriteLine("4. ELIMINAR ULTIMA POSICION");
                Console.WriteLine("5. ELIMINAR POSICION INTERMEDIA");
                Console.WriteLine("6. SALIR");
                Console.Write("ESCOJA UNA OPCION: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese una edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        manager.Insertar(edad);    // Inserta la edad en la lista
                        break;

                    case 2:
                        manager.Mostrar();         // Muestra las edades en la lista
                        break;

                    case 3:
                        manager.EliminarPrimeraPosicion();  // Elimina la primera edad en la lista
                        break;

                    case 4:
                        manager.EliminarUltimaPosicion();   // Elimina la última edad en la lista
                        break;

                    case 5:
                        Console.Write("Ingrese la posición a eliminar (0 a N-1): ");
                        int posicionEliminar = int.Parse(Console.ReadLine());
                        manager.EliminarPosicionIntermedia(posicionEliminar);  // Elimina una edad en una posición intermedia
                        break;

                    case 6:
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
