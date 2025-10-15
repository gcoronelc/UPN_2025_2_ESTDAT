using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioExpresiones
{
    // ==================== CLASE PARSER DE EXPRESIONES ====================
    public class ParserExpresion
    {
        // Método principal para convertir expresión infija a árbol
        public NodoArbol ConvertirInfijaAArbol(string expresion)
        {
            // Limpiar la expresión
            expresion = expresion.Replace(" ", "");

            // Validar expresión
            if (!ValidarExpresion(expresion))
            {
                throw new ArgumentException("Expresión no válida");
            }

            // Convertir a notación postfija primero
            string postfija = InfijaAPostfija(expresion);

            // Construir árbol desde postfija
            return ConstruirArbolDesdePostfija(postfija);
        }

        // Validar que la expresión sea correcta
        private bool ValidarExpresion(string expresion)
        {
            if (string.IsNullOrEmpty(expresion))
                return false;

            int parentesis = 0;
            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];
                if (c == '(') parentesis++;
                if (c == ')') parentesis--;
                if (parentesis < 0) return false;
            }
            return parentesis == 0;
        }

        // Obtener precedencia de operadores
        private int ObtenerPrecedencia(char operador)
        {
            switch (operador)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        // Verificar si es un operador
        private bool EsOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Verificar si es un dígito o punto decimal
        private bool EsNumero(char c)
        {
            return char.IsDigit(c) || c == '.';
        }

        // Convertir expresión infija a postfija (Algoritmo Shunting Yard)
        private string InfijaAPostfija(string infija)
        {
            StringBuilder salida = new StringBuilder();
            Stack<char> pila = new Stack<char>();

            for (int i = 0; i < infija.Length; i++)
            {
                char c = infija[i];

                // Si es un número (puede ser decimal)
                if (EsNumero(c))
                {
                    while (i < infija.Length && EsNumero(infija[i]))
                    {
                        salida.Append(infija[i]);
                        i++;
                    }
                    i--; // Retroceder uno
                    salida.Append(' '); // Separador
                }
                // Si es paréntesis izquierdo
                else if (c == '(')
                {
                    pila.Push(c);
                }
                // Si es paréntesis derecho
                else if (c == ')')
                {
                    while (pila.Count > 0 && pila.Peek() != '(')
                    {
                        salida.Append(pila.Pop());
                        salida.Append(' ');
                    }
                    if (pila.Count > 0)
                        pila.Pop(); // Quitar '('
                }
                // Si es un operador
                else if (EsOperador(c))
                {
                    while (pila.Count > 0 &&
                           ObtenerPrecedencia(pila.Peek()) >= ObtenerPrecedencia(c))
                    {
                        salida.Append(pila.Pop());
                        salida.Append(' ');
                    }
                    pila.Push(c);
                }
            }

            // Vaciar la pila
            while (pila.Count > 0)
            {
                salida.Append(pila.Pop());
                salida.Append(' ');
            }

            return salida.ToString().Trim();
        }

        // Construir árbol desde notación postfija
        private NodoArbol ConstruirArbolDesdePostfija(string postfija)
        {
            Stack<NodoArbol> pila = new Stack<NodoArbol>();
            string[] tokens = postfija.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                // Si es un operador
                if (token.Length == 1 && EsOperador(token[0]))
                {
                    NodoArbol derecho = pila.Pop();
                    NodoArbol izquierdo = pila.Pop();
                    NodoArbol nodo = new NodoArbol(token)
                    {
                        Izquierdo = izquierdo,
                        Derecho = derecho
                    };
                    pila.Push(nodo);
                }
                // Si es un operando
                else
                {
                    pila.Push(new NodoArbol(token));
                }
            }

            return pila.Pop();
        }
    }
}
