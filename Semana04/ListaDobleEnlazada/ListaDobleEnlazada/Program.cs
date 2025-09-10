using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DoublyLinkedList list = new DoublyLinkedList();
            
            list.AddFirst(50);
            list.AddFirst(40);
            list.AddFirst(30);
            list.PrintList();

            list.AddLast(70);
            list.AddLast(20);
            list.AddLast(60);
            list.PrintList();

            /*
            list.PrintListReverse();
            Console.WriteLine("----------------");
            int data = list.ExtraerDesdeFinal();
            data = list.ExtraerDesdeFinal();
            data = list.ExtraerDesdeFinal();
            data = list.ExtraerDesdeFinal();
            data = list.ExtraerDesdeFinal();
            data = list.ExtraerDesdeFinal();
            Console.WriteLine(data);
            list.PrintList();
            list.PrintListReverse();
            */



            list.Remove(30);
            list.Remove(20);
            list.Remove(60);
            list.PrintList();
            list.PrintListReverse();

            Console.ReadKey();
        }
    }
}
