using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            ArbolEstudiantes arbol = new ArbolEstudiantes();
            int opcion;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║  SISTEMA DE REGISTRO DE ESTUDIANTES    ║");
                Console.WriteLine("║       (Árbol Binario de Búsqueda)      ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Buscar estudiante");
                Console.WriteLine("3. Mostrar todos los estudiantes");
                Console.WriteLine("4. Mostrar estructura del árbol");
                Console.WriteLine("5. Mostrar estadísticas");
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
                        Console.Write("\nIngrese el nombre del estudiante: ");
                        string nombre = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(nombre))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        Console.Write("Ingrese la nota (0-20): ");
                        if (double.TryParse(Console.ReadLine(), out double nota))
                        {
                            if (nota >= 0 && nota <= 20)
                            {
                                arbol.Agregar(nombre, nota);
                            }
                            else
                            {
                                Console.WriteLine("La nota debe estar entre 0 y 20.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nota no válida.");
                        }
                        break;

                    case 2:
                        Console.Write("\nIngrese el nombre del estudiante a buscar: ");
                        string nombreBuscar = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(nombreBuscar))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            break;
                        }

                        arbol.Buscar(nombreBuscar);
                        break;

                    case 3:
                        arbol.ImprimirInOrden();
                        break;

                    case 4:
                        arbol.ImprimirArbol();
                        break;

                    case 5:
                        int total = arbol.ContarEstudiantes();
                        Console.WriteLine("\n═══════════════════════════════════════");
                        Console.WriteLine("          ESTADÍSTICAS");
                        Console.WriteLine("═══════════════════════════════════════");
                        Console.WriteLine($"  Total de estudiantes: {total}");
                        if (total > 0)
                        {
                            double promedio = arbol.CalcularPromedio();
                            Console.WriteLine($"  Promedio general: {promedio:F2}");
                        }
                        Console.WriteLine("═══════════════════════════════════════");
                        break;

                    case 0:
                        Console.WriteLine("\n¡Hasta luego!");
                        Console.WriteLine("Presione cualquier tecla para salir...");
                        Console.ReadKey();
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
