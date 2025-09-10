using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularSimpleEnlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList list = new CircularLinkedList();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddLast(6);
            list.AddLast(7);

            Console.WriteLine("Lista inicial:");
            list.PrintList();  // Output: Lista inicial: 4 5 6 7

            list.Remove(5);

            Console.WriteLine("Lista después de eliminar 5:");
            list.PrintList();  // Output: Lista después de eliminar 5: 4 6 7

            Console.WriteLine("Número de nodos: " + list.Count);  // Output: Número de nodos: 3
            
            Console.ReadKey();
        }
    }
}
