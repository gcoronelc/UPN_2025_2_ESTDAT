using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class ArbolBinario
    {

        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            this.Raiz = null;
        }

        public void AgregarNodo(int dato)
        {
            Raiz = AgregarRecursivo(this.Raiz,dato);
         }

        public Nodo AgregarRecursivo(Nodo raiz, int valor)
        {
            if(raiz == null)
            {
               return new Nodo(valor);
            }
            if(valor < raiz.Dato)
            {
                raiz.Izquierda = AgregarRecursivo(raiz.Izquierda, valor);
            }
            else if(valor > raiz.Dato)
            {
                raiz.Derecha = AgregarRecursivo(raiz.Derecha, valor);
            }
            return raiz;
        }


        public void ImprimirInOrden()
        {
            Console.Write("Recorrido InOrden: ");
            ImprimirInOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirInOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirInOrdenRecursivo(raiz.Izquierda);
                Console.Write(raiz.Dato + " ");
                ImprimirInOrdenRecursivo(raiz.Derecha);
            }
        }


        public void ImprimirPreOrden()
        {
            Console.Write("Recorrido PreOrden: ");
            ImprimirPreOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        private void ImprimirPreOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                Console.Write(raiz.Dato + " ");
                ImprimirPreOrdenRecursivo(raiz.Izquierda);
                ImprimirPreOrdenRecursivo(raiz.Derecha);
            }
        }

        public void ImprimirPostOrden()
        {
            Console.Write("Recorrido PostOrden: ");
            ImprimirPostOrdenRecursivo(this.Raiz);
            Console.WriteLine();
        }

        public void ImprimirPostOrdenRecursivo(Nodo raiz)
        {
            if(raiz != null)
            {
                ImprimirPostOrdenRecursivo(raiz.Izquierda);
                ImprimirPostOrdenRecursivo(raiz.Derecha);
                Console.Write(raiz.Dato + " ");
            }
        }


    }
}
