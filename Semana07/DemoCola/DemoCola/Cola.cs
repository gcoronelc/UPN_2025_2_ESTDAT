using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace DemoCola
{
    public class Cola
    {
        private Nodo Inicio;
        private Nodo Ultimo;

        public Cola()
        {
            this.Inicio = null;
            this.Ultimo = null;
        }
        public void Encolar(string nombre, int nota)
        {
            Nodo nuevo = new Nodo(nombre, nota);
            if (this.Inicio == null)
            {
                this.Inicio = nuevo;
                this.Ultimo = nuevo;
                return;
            }
            this.Ultimo.Siguiente = nuevo;
            this.Ultimo = nuevo;
        }

        public void Imprimir()
        {
            if (this.Inicio == null)
            {
                Console.WriteLine("Cola vacía");
                return;
            }
            
            Console.Write("Cola:");
            Nodo actual = this.Inicio;
            while (actual != null)
            {
                string dato = actual.Nombre + "(" + actual.Nota + ") ";
                Console.Write(dato);
                actual = actual.Siguiente;
            }
            Console.WriteLine();
            
        }
        
        public Nodo Desencolar()
        {
            if (this.Inicio == null)
            {
                return null;
            }
            Nodo actual;
            if (this.Ultimo == this.Inicio)
            {
                actual = this.Inicio;
                this.Inicio = null;
                this.Ultimo = null;
                return actual ;
            }
            actual = this.Inicio;
            this.Inicio = this.Inicio.Siguiente;
            actual.Siguiente = null;
            return actual;
        }
       
    }
}
