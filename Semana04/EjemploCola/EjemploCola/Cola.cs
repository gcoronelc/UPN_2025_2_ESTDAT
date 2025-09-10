using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Cola
    {
        private Nodo frente;
        private Nodo final;

        public Cola()
        {
            frente = null;
            final = null;
        }

        public void Encolar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (final == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public int Desencolar()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está vacía.");

            int valor = frente.Valor;
            frente = frente.Siguiente;
            if (frente == null)
            {
                final = null;
            }
            return valor;
        }

        public int Frente()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está vacía.");

            return frente.Valor;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }
    }
}
