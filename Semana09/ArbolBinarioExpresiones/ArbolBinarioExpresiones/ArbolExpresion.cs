using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioExpresiones
{
    // ==================== CLASE ÁRBOL DE EXPRESIÓN ====================
    public class ArbolExpresion
    {
        private NodoArbol raiz;

        public ArbolExpresion(NodoArbol raiz)
        {
            this.raiz = raiz;
        }

        // Evaluar la expresión del árbol
        public double Evaluar()
        {
            return EvaluarNodo(raiz);
        }

        private double EvaluarNodo(NodoArbol nodo)
        {
            if (nodo == null)
                throw new InvalidOperationException("Nodo nulo en el árbol");

            // Si es hoja, retornar el valor numérico
            if (nodo.EsHoja())
            {
                return double.Parse(nodo.Valor);
            }

            // Evaluar subárboles
            double valorIzquierdo = EvaluarNodo(nodo.Izquierdo);
            double valorDerecho = EvaluarNodo(nodo.Derecho);

            // Aplicar operación
            switch (nodo.Valor)
            {
                case "+":
                    return valorIzquierdo + valorDerecho;
                case "-":
                    return valorIzquierdo - valorDerecho;
                case "*":
                    return valorIzquierdo * valorDerecho;
                case "/":
                    if (Math.Abs(valorDerecho) < 0.0000001)
                        throw new DivideByZeroException("División por cero");
                    return valorIzquierdo / valorDerecho;
                default:
                    throw new InvalidOperationException($"Operador desconocido: {nodo.Valor}");
            }
        }

        // Notación INFIJA (Recorrido Inorden)
        public string ObtenerInfija()
        {
            return InordenRecursivo(raiz).Trim();
        }

        private string InordenRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return "";

            if (nodo.EsHoja())
                return nodo.Valor;

            string resultado = "(";
            resultado += InordenRecursivo(nodo.Izquierdo);
            resultado += " " + nodo.Valor + " ";
            resultado += InordenRecursivo(nodo.Derecho);
            resultado += ")";

            return resultado;
        }

        // Notación PREFIJA (Recorrido Preorden)
        public string ObtenerPrefija()
        {
            return PreordenRecursivo(raiz).Trim();
        }

        private string PreordenRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return "";

            if (nodo.EsHoja())
                return nodo.Valor + " ";

            string resultado = nodo.Valor + " ";
            resultado += PreordenRecursivo(nodo.Izquierdo);
            resultado += PreordenRecursivo(nodo.Derecho);

            return resultado;
        }

        // Notación POSTFIJA (Recorrido Postorden)
        public string ObtenerPostfija()
        {
            return PostordenRecursivo(raiz).Trim();
        }

        private string PostordenRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return "";

            if (nodo.EsHoja())
                return nodo.Valor + " ";

            string resultado = "";
            resultado += PostordenRecursivo(nodo.Izquierdo);
            resultado += PostordenRecursivo(nodo.Derecho);
            resultado += nodo.Valor + " ";

            return resultado;
        }

        // Visualización gráfica del árbol (ASCII Art)
        public string VisualizarArbol()
        {
            StringBuilder sb = new StringBuilder();
            VisualizarArbolRecursivo(raiz, "", true, sb);
            return sb.ToString();
        }

        private void VisualizarArbolRecursivo(NodoArbol nodo, string prefijo, bool esUltimo, StringBuilder sb)
        {
            if (nodo == null)
                return;

            sb.Append(prefijo);
            sb.Append(esUltimo ? "└── " : "├── ");
            sb.AppendLine(nodo.Valor);

            List<NodoArbol> hijos = new List<NodoArbol>();
            if (nodo.Izquierdo != null) hijos.Add(nodo.Izquierdo);
            if (nodo.Derecho != null) hijos.Add(nodo.Derecho);

            for (int i = 0; i < hijos.Count; i++)
            {
                bool ultimo = (i == hijos.Count - 1);
                string extension = esUltimo ? "    " : "│   ";
                VisualizarArbolRecursivo(hijos[i], prefijo + extension, ultimo, sb);
            }
        }

        // Obtener altura del árbol
        public int ObtenerAltura()
        {
            return ObtenerAlturaRecursivo(raiz);
        }

        private int ObtenerAlturaRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzq = ObtenerAlturaRecursivo(nodo.Izquierdo);
            int alturaDer = ObtenerAlturaRecursivo(nodo.Derecho);

            return 1 + Math.Max(alturaIzq, alturaDer);
        }

        // Contar número de nodos
        public int ContarNodos()
        {
            return ContarNodosRecursivo(raiz);
        }

        private int ContarNodosRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarNodosRecursivo(nodo.Izquierdo) + ContarNodosRecursivo(nodo.Derecho);
        }

        // Contar número de operadores
        public int ContarOperadores()
        {
            return ContarOperadoresRecursivo(raiz);
        }

        private int ContarOperadoresRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            int cuenta = nodo.EsOperador() ? 1 : 0;
            cuenta += ContarOperadoresRecursivo(nodo.Izquierdo);
            cuenta += ContarOperadoresRecursivo(nodo.Derecho);

            return cuenta;
        }
    }

}
