using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCola
{
    class Program
    {
        static void Main(string[] args)
        {

            Cola alumnos = new Cola();
            alumnos.Encolar("Hade", 20);
            alumnos.Encolar("Dylan", 18);
            alumnos.Encolar("Luz", 20);
            alumnos.Encolar("Lorena", 15);
            
            alumnos.Imprimir();
            
            Nodo actual = alumnos.Desencolar();
            while(actual != null)
            {
                string dato = actual.Nombre + "(" + actual.Nota + ") ";
                Console.WriteLine(dato);
                actual = alumnos.Desencolar();
            }
            
        }
    }
}
