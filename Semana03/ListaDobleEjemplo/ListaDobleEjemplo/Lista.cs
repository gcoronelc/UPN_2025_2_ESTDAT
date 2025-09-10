using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEjemplo
{
    public class Lista
    {

        private Nodo Cabecera;
        private int Contador;

        public Lista()
        {
            Cabecera = null;
            Contador = 0;
        }


        public void agregarAlUltimo(string Nombre, int Nota)
                  {
            Nodo Nuevo = new Nodo(Nombre, Nota);
            if (Contador == 0) // Es el primero de la lista
            {
                Cabecera = Nuevo;
                Contador++;
                return;
            }
            Contador++;
            Nodo Actual = Cabecera;
            while(Actual.Siguiente != null)
            {
                Actual = Actual.Siguiente;
            }
            Actual.Siguiente = Nuevo;
            Nuevo.Anterior = Actual;
        }

        public void mostrarLista()
        {
            Console.WriteLine("LISTA");
            if(this.Contador == 0)
            {
                Console.WriteLine("Lista vacia.");
                return;
            }
            Console.WriteLine("Tamaño: " + this.Contador);
            Console.Write("NODOS: ");
            Nodo Actual = Cabecera;
            while (Actual != null)
            {
                Console.Write("(" + Actual.Nombre + "," + Actual.Nota + ") ");
                Actual = Actual.Siguiente;
            }
            Console.WriteLine("");
        }

        public Nodo ObtenerElMejor()
        {
            if(this.Cabecera == null)
            {
                return null;
            }
            Nodo Mejor = Cabecera;
            Nodo Actual = Mejor.Siguiente;
            while(Actual != null)
            {
                if(Actual.Nota > Mejor.Nota)
                {
                    Mejor = Actual;
                }
                Actual = Actual.Siguiente;
            }
            return Mejor;
        }

    }
}
