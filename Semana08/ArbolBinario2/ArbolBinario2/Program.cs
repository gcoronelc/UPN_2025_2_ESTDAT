using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            int opcion;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║   ÁRBOL BINARIO DE BÚSQUEDA        ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.WriteLine("1. Agregar nodo");
                Console.WriteLine("2. Buscar elemento");
                Console.WriteLine("3. Imprimir árbol (In-Orden)");
                Console.WriteLine("4. Imprimir árbol (Pre-Orden)");
                Console.WriteLine("5. Imprimir árbol (Post-Orden)");
                Console.WriteLine("6. Mostrar estructura del árbol");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    opcion = -1; // Reiniciar opción para evitar salir del bucle
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor a agregar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorAgregar))
                        {
                            arbol.Agregar(valorAgregar);
                        }
                        else
                        {
                            Console.WriteLine("Valor no válido.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                        {
                            bool encontrado = arbol.Buscar(valorBuscar);
                            if (encontrado)
                            {
                                Console.WriteLine($"El valor {valorBuscar} SÍ existe en el árbol.");
                            }
                            else
                            {
                                Console.WriteLine($"El valor {valorBuscar} NO existe en el árbol.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor no válido.");
                        }
                        break;

                    case 3:
                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("El árbol está vacío.");
                        }
                        else
                        {
                            arbol.ImprimirInOrden();
                        }
                        break;

                    case 4:
                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("El árbol está vacío.");
                        }
                        else
                        {
                            arbol.ImprimirPreOrden();
                        }
                        break;

                    case 5:
                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("El árbol está vacío.");
                        }
                        else
                        {
                            arbol.ImprimirPostOrden();
                        }
                        break;

                    case 6:
                        if (arbol.Raiz == null)
                        {
                            Console.WriteLine("El árbol está vacío.");
                        }
                        else
                        {
                            arbol.ImprimirArbol();
                        }
                        break;

                    case 0:
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 0);
        }
    }
}
