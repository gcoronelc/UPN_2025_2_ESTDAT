using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01
{
    public class Lista
    {
        public Nodo Primero;   // Referencia al primer nodo de la lista
        public int Contador;   // Contador de nodos

        public Lista()
        {
            Primero = null;   // Inicializa la lista enlazada como vacía al principio
            Contador = 0;     // Inicialmente la lista no tiene ningun nodo
        }

        public int getContador()
        {
            return Contador;
        }

        public void nuevoNodo(int valor)
        {
            Nodo Nuevo = new Nodo(valor);
            Nuevo.Siguiente = Primero;
            Primero = Nuevo;
            Contador++;
        }

        public void mostrarLista()
        {
            if (Primero == null)
            {
                Console.WriteLine("Lista vacia");
                return;
            } 
            Console.Write("Lista: ");
            Nodo actual = Primero;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        public int sumar()
        {
            int suma = 0;
            Nodo actual = Primero;
            while (actual != null)
            {
                suma += actual.Valor;
                actual = actual.Siguiente;
            }
            return suma;
        }

        public double promediar()
        {
            double promedio = (Contador>0)? sumar() / Contador : 0;
            return promedio;
        }

    }
}
