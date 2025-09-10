using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaSimple
{
    public class Cola
    {
        private Nodo Frente;
        private Nodo Final;
        private int Tamanio;

        public Cola()
        {
            this.Frente = null;
            this.Final = null;
            this.Tamanio = 0;
        }

        public int getTamanio()
        {
            return this.Tamanio;
        }

        public void agregarNodo(string Nombre)
        {
            Nodo nuevoNodo = new Nodo(Nombre);
            if (this.Tamanio == 0)
            {
                this.Frente = nuevoNodo;
                this.Final = nuevoNodo;
            } else
            {
                this.Final.Siguiente = nuevoNodo;
                this.Final = nuevoNodo;
            }
            this.Tamanio++;
        }

        public string extraerNodo()
        {
            if(this.Tamanio == 0)
            {
                return null;
            }
            string dato = this.Frente.Nombre; ;
            if (this.Tamanio == 1)
            {
                this.Frente = null;
                this.Final = null;
                this.Tamanio = 0;
                return dato;
            }
            this.Frente = this.Frente.Siguiente;
            this.Tamanio--;
            return dato;
        }
    }
}
