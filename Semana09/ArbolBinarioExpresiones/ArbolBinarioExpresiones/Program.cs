using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioExpresiones
{
    // ==================== PROGRAMA PRINCIPAL ====================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  SISTEMA DE EVALUACIÓN DE ÁRBOLES DE EXPRESIONES EN C#   ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("Ingrese una expresión matemática (o 'salir' para terminar):");
                    Console.Write("Expresión: ");
                    string expresion = Console.ReadLine();

                    if (expresion.ToLower() == "salir")
                    {
                        continuar = false;
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    }

                    if (string.IsNullOrWhiteSpace(expresion))
                    {
                        Console.WriteLine("⚠ Error: La expresión no puede estar vacía.\n");
                        continue;
                    }

                    // Crear el parser y convertir la expresión a árbol
                    ParserExpresion parser = new ParserExpresion();
                    NodoArbol raiz = parser.ConvertirInfijaAArbol(expresion);

                    // Crear el árbol de expresión
                    ArbolExpresion arbol = new ArbolExpresion(raiz);

                    // Mostrar resultados
                    Console.WriteLine("\n" + new string('═', 65));
                    Console.WriteLine("RESULTADOS DEL ANÁLISIS");
                    Console.WriteLine(new string('═', 65));

                    // 1. Visualización del árbol
                    Console.WriteLine("\n1. ÁRBOL BINARIO DE EXPRESIÓN:");
                    Console.WriteLine(new string('─', 65));
                    Console.WriteLine(arbol.VisualizarArbol());

                    // 2. Notación Infija
                    Console.WriteLine("2. NOTACIÓN INFIJA (Inorden):");
                    Console.WriteLine(new string('─', 65));
                    Console.WriteLine($"   {arbol.ObtenerInfija()}");
                    Console.WriteLine();

                    // 3. Notación Prefija
                    Console.WriteLine("3. NOTACIÓN PREFIJA (Preorden):");
                    Console.WriteLine(new string('─', 65));
                    Console.WriteLine($"   {arbol.ObtenerPrefija()}");
                    Console.WriteLine();

                    // 4. Notación Postfija
                    Console.WriteLine("4. NOTACIÓN POSTFIJA (Postorden):");
                    Console.WriteLine(new string('─', 65));
                    Console.WriteLine($"   {arbol.ObtenerPostfija()}");
                    Console.WriteLine();

                    // 5. Evaluación
                    Console.WriteLine("5. EVALUACIÓN DE LA EXPRESIÓN:");
                    Console.WriteLine(new string('─', 65));
                    double resultado = arbol.Evaluar();
                    Console.WriteLine($"   Resultado = {resultado}");
                    Console.WriteLine();

                    // 6. Información adicional
                    Console.WriteLine("6. INFORMACIÓN DEL ÁRBOL:");
                    Console.WriteLine(new string('─', 65));
                    Console.WriteLine($"   • Altura del árbol: {arbol.ObtenerAltura()}");
                    Console.WriteLine($"   • Número total de nodos: {arbol.ContarNodos()}");
                    Console.WriteLine($"   • Número de operadores: {arbol.ContarOperadores()}");
                    Console.WriteLine($"   • Número de operandos: {arbol.ContarNodos() - arbol.ContarOperadores()}");
                    Console.WriteLine();

                    Console.WriteLine(new string('═', 65));
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"\n⚠ Error: {ex.Message}\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\n⚠ Error: {ex.Message}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n⚠ Error inesperado: {ex.Message}\n");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
                Console.WriteLine("║  SISTEMA DE EVALUACIÓN DE ÁRBOLES DE EXPRESIONES EN C#   ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
                Console.WriteLine();
            }
        }
    }
}
