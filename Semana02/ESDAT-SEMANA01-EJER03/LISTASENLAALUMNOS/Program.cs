using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTASENLAALUMNOS
{
    class Program
    {
        class Alumno
        {
            public string Nombre;        // Nombre del alumno
            public string Materia;       // Materia en la que está inscrito
            public string CodigoTurno;   // Código de turno al que pertenece

            public Alumno(string nombre, string materia, string codigoTurno)
            {
                Nombre = nombre;         // Inicializa el nombre del alumno
                Materia = materia;       // Inicializa la materia del alumno
                CodigoTurno = codigoTurno;   // Inicializa el código de turno del alumno
            }
        }

        class Nodo
        {
            public Alumno Datos;         // Datos del alumno almacenados en el nodo
            public Nodo Siguiente;       // Referencia al siguiente nodo en la lista enlazada

            public Nodo(Alumno alumno)
            {
                Datos = alumno;          // Inicializa los datos del nodo con los datos del alumno
                Siguiente = null;        // Inicializa la referencia al siguiente nodo como nula
            }
        }

        static void Main(string[] args)
        {
            List<Nodo> listaAlumnos = new List<Nodo>();   // Lista de nodos para almacenar alumnos

            Console.Write("Ingrese la cantidad de alumnos: ");
            int cantidadAlumnos = int.Parse(Console.ReadLine());

            // Captura de datos de los alumnos
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine($"Ingrese los datos del alumno {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Materia: ");
                string materia = Console.ReadLine();

                Console.Write("Código de turno: ");
                string codigoTurno = Console.ReadLine();

                Alumno alumno = new Alumno(nombre, materia, codigoTurno);
                Nodo nodoAlumno = new Nodo(alumno);
                listaAlumnos.Add(nodoAlumno);   // Agrega el nodo del alumno a la lista
            }

            // Mostrar los datos de inscripciones
            Console.WriteLine("\nDatos de inscripciones:");
            foreach (Nodo nodo in listaAlumnos)
            {
                Alumno alumno = nodo.Datos;
                Console.WriteLine($"Nombre: {alumno.Nombre}");
                Console.WriteLine($"Materia: {alumno.Materia}");
                Console.WriteLine($"Código de turno: {alumno.CodigoTurno}");
                Console.WriteLine();
            }

            // Esperar a que el usuario pulse una tecla antes de salir
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
