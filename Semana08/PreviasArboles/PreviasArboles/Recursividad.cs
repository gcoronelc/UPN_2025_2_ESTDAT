using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviasArboles
{
    public class Recursividad
    {

        public static int Factorial(int n)
        {
            // Validación de entrada
            if (n < 0)
            {
                throw new ArgumentException("El número debe ser no negativo.");
            }
            // Caso base
            if (n == 0 || n == 1)
            {
                return 1;
            }
            // Caso recursivo
            return n * Factorial(n - 1);
        }



    }
}
