using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario3
{
    public class ArbolEstudiantes
    {
        public Nodo Raiz { get; private set; }

        public ArbolEstudiantes()
        {
            Raiz = null;
        }

        // Método para agregar un estudiante
        public void Agregar(string nombre, double nota)
        {
            Estudiante estudiante = new Estudiante(nombre, nota);
            Raiz = AgregarRecursivo(Raiz, estudiante);
            Console.WriteLine($"Estudiante {estudiante.Nombre} agregado correctamente con nota {nota:F2}");
        }

        private Nodo AgregarRecursivo(Nodo nodo, Estudiante estudiante)
        {
            // Si el nodo es null, crear un nuevo nodo
            if (nodo == null)
            {
                return new Nodo(estudiante);
            }

            // Comparar por nombre (orden alfabético)
            int comparacion = string.Compare(estudiante.Nombre, nodo.Datos.Nombre, StringComparison.Ordinal);

            // Si el nombre es menor alfabéticamente, ir al subárbol izquierdo
            if (comparacion < 0)
            {
                nodo.Izquierdo = AgregarRecursivo(nodo.Izquierdo, estudiante);
            }
            // Si el nombre es mayor alfabéticamente, ir al subárbol derecho
            else if (comparacion > 0)
            {
                nodo.Derecho = AgregarRecursivo(nodo.Derecho, estudiante);
            }
            else
            {
                // Si el nombre ya existe, actualizar la nota
                Console.WriteLine($"El estudiante {estudiante.Nombre} ya existe. Actualizando nota...");
                nodo.Datos = estudiante;
            }

            return nodo;
        }

        // Método para buscar un estudiante por nombre
        public bool Buscar(string nombre)
        {
            nombre = nombre.ToUpper();
            Nodo resultado = BuscarRecursivo(Raiz, nombre);

            if (resultado != null)
            {
                Console.WriteLine($"\n✓ Estudiante encontrado:");
                Console.WriteLine($"  Nombre: {resultado.Datos.Nombre}");
                Console.WriteLine($"  Nota: {resultado.Datos.Nota:F2}");
                return true;
            }
            else
            {
                Console.WriteLine($"\n✗ El estudiante {nombre} NO se encuentra registrado.");
                return false;
            }
        }

        private Nodo BuscarRecursivo(Nodo nodo, string nombre)
        {
            // Si el nodo es null, el estudiante no existe
            if (nodo == null)
            {
                return null;
            }

            int comparacion = string.Compare(nombre, nodo.Datos.Nombre, StringComparison.Ordinal);

            // Si encontramos el nombre
            if (comparacion == 0)
            {
                return nodo;
            }

            // Buscar en el subárbol correspondiente
            if (comparacion < 0)
            {
                return BuscarRecursivo(nodo.Izquierdo, nombre);
            }
            else
            {
                return BuscarRecursivo(nodo.Derecho, nombre);
            }
        }

        // Método para imprimir todos los estudiantes (In-Orden - orden alfabético)
        public void ImprimirInOrden()
        {
            Console.WriteLine("\n═══════════════════════════════════════");
            Console.WriteLine("  LISTADO DE ESTUDIANTES (Alfabético)");
            Console.WriteLine("═══════════════════════════════════════");
            if (Raiz == null)
            {
                Console.WriteLine("  No hay estudiantes registrados.");
            }
            else
            {
                ImprimirInOrdenRecursivo(Raiz);
            }
            Console.WriteLine("═══════════════════════════════════════");
        }

        private void ImprimirInOrdenRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                ImprimirInOrdenRecursivo(nodo.Izquierdo);
                Console.WriteLine($"  • {nodo.Datos}");
                ImprimirInOrdenRecursivo(nodo.Derecho);
            }
        }

        // Método para imprimir el árbol de forma visual
        public void ImprimirArbol()
        {
            Console.WriteLine("\n═══════════════════════════════════════");
            Console.WriteLine("      ESTRUCTURA DEL ÁRBOL");
            Console.WriteLine("═══════════════════════════════════════");
            if (Raiz == null)
            {
                Console.WriteLine("  El árbol está vacío.");
            }
            else
            {
                ImprimirArbolRecursivo(Raiz, "", true);
            }
        }

        private void ImprimirArbolRecursivo(Nodo nodo, string indent, bool ultimo)
        {
            if (nodo != null)
            {
                Console.Write(indent);
                if (ultimo)
                {
                    Console.Write("└─");
                    indent += "  ";
                }
                else
                {
                    Console.Write("├─");
                    indent += "│ ";
                }
                Console.WriteLine($"{nodo.Datos.Nombre} ({nodo.Datos.Nota:F2})");

                ImprimirArbolRecursivo(nodo.Izquierdo, indent, false);
                ImprimirArbolRecursivo(nodo.Derecho, indent, true);
            }
        }

        // Método para contar estudiantes
        public int ContarEstudiantes()
        {
            return ContarRecursivo(Raiz);
        }

        private int ContarRecursivo(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + ContarRecursivo(nodo.Izquierdo) + ContarRecursivo(nodo.Derecho);
        }

        // Método para calcular promedio de notas
        public double CalcularPromedio()
        {
            int total = ContarEstudiantes();
            if (total == 0)
                return 0;

            double suma = SumarNotasRecursivo(Raiz);
            return suma / total;
        }

        private double SumarNotasRecursivo(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            return nodo.Datos.Nota + SumarNotasRecursivo(nodo.Izquierdo) + SumarNotasRecursivo(nodo.Derecho);
        }
    }
}
