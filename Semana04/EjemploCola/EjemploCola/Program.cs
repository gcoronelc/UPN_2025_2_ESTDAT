using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cola
            Cola cola = new Cola();

            // Encolar elementos
            cola.Encolar(1);
            cola.Encolar(2);
            cola.Encolar(3);

            // Obtener el elemento en el frente de la cola
            int frente = cola.Frente(); // Resultado: 1
            Console.WriteLine(frente);

            // Desencolar elementos
            int desencolado = cola.Desencolar(); // Resultado: 1
            Console.WriteLine(desencolado); // Salida: 1

            // Verificar si la cola está vacía
            bool estaVacia = cola.EstaVacia(); // Resultado: false
            Console.WriteLine(estaVacia);

            Console.ReadKey();
        }
    }
}
