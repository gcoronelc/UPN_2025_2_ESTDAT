using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddFirst("Gustavo");
            list.AddFirst("Karol");
            list.AddLast("Alejandra");
            list.AddLast("Mariel");

            list.print();

            Console.ReadKey();
        }
    }
}
