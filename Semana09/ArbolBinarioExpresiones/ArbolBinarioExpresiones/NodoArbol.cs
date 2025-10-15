using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioExpresiones
{
    // ==================== CLASE NODO DEL ÁRBOL ====================
    public class NodoArbol
    {
        public string Valor { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        public NodoArbol(string valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }

        public bool EsOperador()
        {
            return Valor == "+" || Valor == "-" || Valor == "*" || Valor == "/";
        }

        public bool EsHoja()
        {
            return Izquierdo == null && Derecho == null;
        }
    }
}
