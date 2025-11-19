using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo ListaRutasv = new Grafo();
            InicializarGrafo(ListaRutasv);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Mostrar rutas posibles a Villa María desde Buenos Aires");
                Console.WriteLine("2. Mostrar el camino más corto a Villa María desde Buenos Aires");
                Console.WriteLine("3. Cerrar programa");
                Console.Write("Seleccione una opción: ");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine();
                        ListaRutasv.MostrarRutas("Buenos Aires", "Villa María");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();    
                        ListaRutasv.MostrarCaminoMasCorto("Buenos Aires", "Villa María");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Programa finalizado.");
                        return;
                    default:
                        Console.WriteLine("Esa opción no existe.");
                        break;
                }
            }
        }
        static void InicializarGrafo(Grafo grafo)
        {
            Nodo buenosAires = grafo.AgregarNodo("Buenos Aires");
            Nodo sanPedro = grafo.AgregarNodo("San Pedro");
            Nodo rosario = grafo.AgregarNodo("Rosario");
            Nodo villaMaria = grafo.AgregarNodo("Villa María");
            Nodo sanLuis = grafo.AgregarNodo("San Luis");
            Nodo bahiaBlanca = grafo.AgregarNodo("Bahía Blanca");
            grafo.AgregarArista("Buenos Aires", "San Pedro");
            grafo.AgregarArista("San Pedro", "Rosario");
            grafo.AgregarArista("Rosario", "Villa María");
            grafo.AgregarArista("Buenos Aires", "San Luis");
            grafo.AgregarArista("San Luis", "Villa María");
            grafo.AgregarArista("Buenos Aires", "Bahía Blanca");
            grafo.AgregarArista("Bahía Blanca", "San Luis");
            grafo.AgregarArista("San Luis", "Villa María");
        }
    }
}

