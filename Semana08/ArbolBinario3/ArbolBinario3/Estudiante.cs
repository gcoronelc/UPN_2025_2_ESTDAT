using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    // Estructura para almacenar los datos del estudiante
    public struct Estudiante
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public Estudiante(string nombre, double nota)
        {
            Nombre = nombre.ToUpper(); // Convertir a mayúsculas
            Nota = nota;
        }

        public override string ToString()
        {
            return $"{Nombre} - (Nota: {Nota:F2})";
        }
    }
}
