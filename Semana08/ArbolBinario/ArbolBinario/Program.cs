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
            ArbolBinario arbol = new ArbolBinario();
            
            arbol.AgregarNodo(50);
            
            arbol.AgregarNodo(30);
            arbol.AgregarNodo(70);
            arbol.AgregarNodo(20);
            arbol.AgregarNodo(40);
            arbol.AgregarNodo(60);
            arbol.AgregarNodo(80);
            arbol.AgregarNodo(20);
            arbol.AgregarNodo(55);
            
            Console.WriteLine("-------------------------------------------------------------");
            arbol.ImprimirInOrden();
            Console.WriteLine("-------------------------------------------------------------");
            arbol.ImprimirPreOrden();
            Console.WriteLine("-------------------------------------------------------------");
            arbol.ImprimirPostOrden();

        }
    }
}
