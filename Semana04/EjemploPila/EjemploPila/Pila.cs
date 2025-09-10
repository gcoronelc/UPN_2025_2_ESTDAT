using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    internal class Pila
    {

        private Nodo tope;
        
        public Pila()
        {
            tope = null;
        }

        public void Apilar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = tope;
            tope = nuevo;
          }

        public int Desapilar()
        {
            if (tope == null)
                throw new InvalidOperationException("La pila está vacía.");

            int valor = tope.Valor;
            tope = tope.Siguiente;
            return valor;
        }

        public int Cima()
        {
            if (tope == null)
                throw new InvalidOperationException("La pila está vacía.");

            return tope.Valor;
        }

        public bool EstaVacia()
        {
            return tope == null;
        }

        public int Tamanio ()
        {
            int tamanio = 0;
            Nodo auxiliar = tope;
            while(auxiliar != null)
            {
                tamanio++;
                auxiliar = auxiliar.Siguiente;
            }
            return tamanio;
        }

        public Pila GetPares()
        {
            Pila pares = new Pila();
            Nodo auxiliar = tope;
            while (auxiliar != null)
            {
                if (auxiliar.Valor%2 == 0)
                {
                    pares.Apilar(auxiliar.Valor);
                }
                auxiliar = auxiliar.Siguiente;
            }


            return pares;
        }

        public void Imprimir()
        {
                      Nodo auxiliar = tope;
            while (auxiliar != null)
            {
                Console.WriteLine(auxiliar.Valor.ToString());
                auxiliar = auxiliar.Siguiente;
            }
        }
    }
}
