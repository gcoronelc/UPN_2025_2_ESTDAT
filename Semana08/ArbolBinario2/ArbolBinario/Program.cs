using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Arbol raiz = new Arbol("Pedro",12);
            raiz.agregarNodo("Juan", 15);
            raiz.agregarNodo("Mnuel", 10);
            raiz.agregarNodo("Karla", 13);
            raiz.agregarNodo("Karla", 18);
            raiz.agregarNodo("Daniel", 16);

            Console.WriteLine("Por ahora todo bien!!!");

            raiz.imprimir();
            Console.ReadKey();

        }
    }
}
