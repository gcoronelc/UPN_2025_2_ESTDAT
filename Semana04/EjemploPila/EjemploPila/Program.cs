using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pila pila = new Pila();

            // Apilar elementos
            pila.Apilar(30);
            pila.Apilar(50);
            pila.Apilar(25);
            pila.Apilar(60);
            pila.Apilar(75);
            pila.Apilar(15);
            pila.Apilar(11);

            int tamanio = pila.Tamanio();
            Console.WriteLine("Tamaño: " + tamanio);

            // Obtener el elemento en la cima de la pila
            int cima = pila.Cima(); 
            Console.WriteLine("Cima: " + cima);


            // Desapilar elementos
            int desapilado = pila.Desapilar();
            desapilado = pila.Desapilar();
            Console.WriteLine("Desapilado: " + desapilado); 

            // Verificar si la pila está vacía
            bool estaVacia = pila.EstaVacia(); 
            Console.WriteLine("Vacio: " + estaVacia);

            Console.WriteLine("Tamaño: " + pila.Tamanio());

            pila.Imprimir();

            Pila Pares = pila.GetPares();
            Console.WriteLine("-------------");
            Pares.Imprimir();
            Console.ReadKey();

        }
    }
}
