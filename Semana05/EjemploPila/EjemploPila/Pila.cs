using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{

    public class Pila
    {
        // Variables
        Nodo Cabecera;


        // Constructor
        public Pila()
        {
            this.Cabecera = null;
        }

        // Un metodo para saber si la pila esta vacia

        public bool EstaVacia()
        {
            return (this.Cabecera == null);
        }

        // Programar el Push

        public void Push (string Nombre)
        {
            Nodo actual = new Nodo(Nombre);
            actual.Siguiente = this.Cabecera;
            this.Cabecera = actual;
        }

        // Metodo para mostrar contenido
        public void Mostrar()
        {
            Nodo actual = this.Cabecera;
            while (actual != null)
            {
                Console.WriteLine(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        // Metodo Pop
        public string Pop()
        {
            if(this.Cabecera== null)
            {
                return null;
            }
            string Nombre = this.Cabecera.Nombre;
            Nodo actual = this.Cabecera;
            this.Cabecera = this.Cabecera.Siguiente;
            actual.Siguiente = null;
            return Nombre;
        }

        public string Peek()
        {
            if (this.Cabecera == null)
            {
                return null;
            }
            return this.Cabecera.Nombre;
        }
    }
}
