using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaSimple
{
    class Program
    {
        static void Main(string[] args)
        {

            Cola cola = new Cola();
            Console.WriteLine("Tamaño: " + cola.getTamanio());

            Console.WriteLine("================================");
            cola.agregarNodo("Luz");
            cola.agregarNodo("Camila");
            cola.agregarNodo("Ismael");
            Console.WriteLine("Tamaño: " + cola.getTamanio());

            Console.WriteLine("================================");
            Console.WriteLine("Esta es la cola:");
            while (cola.getTamanio() > 0)
            {
                string nombre = cola.extraerNodo();
                Console.WriteLine(nombre);
            }

            Console.ReadKey();

        }
    }
}
