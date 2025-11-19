using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3Ejercicio
{
    public class Grafo
    {
        private List<Nodo> nodos;
        public Grafo()
        {
            nodos = new List<Nodo>();
        }
        public Nodo AgregarNodo(string nombre)
        {
            Nodo nodo = new Nodo(nombre);
            nodos.Add(nodo);
            return nodo;
        }
        public Nodo ObtenerNodo(string nombre)
        {
            return nodos.Find(n => n.Ciudad == nombre);
        }
        public void AgregarArista(string Cabeza, string destino)
        {
            Nodo NodoCabeza = ObtenerNodo(Cabeza);
            Nodo NodoDestino = ObtenerNodo(destino);
            if (NodoCabeza != null && NodoDestino != null)
            {
                NodoCabeza.AgregarAdyacente(NodoDestino);
            }
            else
            {
                Console.WriteLine("Nodo no encontrado.");
            }
        }
        public void MostrarRutas(string Cabeza, string destino)
        {
            Nodo NodoCabeza = ObtenerNodo(Cabeza);
            Nodo NodoDestino = ObtenerNodo(destino);
            HashSet<string> rutas = new HashSet<string>();
            if (NodoCabeza != null && NodoDestino != null)
            {
                BuscarRutas(NodoCabeza, NodoDestino, new List<Nodo>(), rutas);
            }
            else
            {
                Console.WriteLine("Nodo no encontrado.");
            }
            Console.WriteLine($"Rutas de {Cabeza} a {destino}:");
            foreach (var ruta in rutas)
            {
                Console.WriteLine(ruta);
            }
        }
        private void BuscarRutas(Nodo at, Nodo destino, List<Nodo> visitados, HashSet<string> rutas)
        {
            visitados.Add(at);
            if (at == destino)
            {
                rutas.Add(string.Join(" -> ", visitados));
            }
            else
            {
                foreach (var adyacente in at.ListAdyacentes)
                {
                    if (!visitados.Contains(adyacente))
                    {
                        BuscarRutas(adyacente, destino, new List<Nodo>(visitados), rutas);
                    }
                }
            }
            visitados.Remove(at);
        }
        public void MostrarCaminoMasCorto(string origen, string destino)
        {
            Nodo NodoCabeza = ObtenerNodo(origen);
            Nodo NodoDestino = ObtenerNodo(destino);
            List<Nodo> RutaCorta = new List<Nodo>();
            if (NodoCabeza != null && NodoDestino != null)
            {
                CaminoCorto(NodoCabeza, NodoDestino, new List<Nodo>(), ref RutaCorta);
            }
            else
            {
                Console.WriteLine("Nodo no encontrado.");
            }
            if (RutaCorta.Count > 0)
            {
                Console.WriteLine($"El camino más corto de {origen} a {destino}:");
                Console.WriteLine(string.Join(" -> ", RutaCorta));
            }
            else
            {
                Console.WriteLine($"No hay un camino de {origen} a {destino}.");
            }
        }
        private void CaminoCorto(Nodo actual, Nodo destino, List<Nodo> visitados, ref List<Nodo> rutaMasCorta)
        {
            visitados.Add(actual);
            if (actual == destino)
            {
                if (rutaMasCorta.Count == 0 || visitados.Count < rutaMasCorta.Count)
                {
                    rutaMasCorta = new List<Nodo>(visitados);
                }
            }
            else
            {
                foreach (var adyacente in actual.ListAdyacentes)
                {
                    if (!visitados.Contains(adyacente))
                    {
                        CaminoCorto(adyacente, destino, new List<Nodo>(visitados), ref rutaMasCorta);
                    }
                }
            }
            visitados.Remove(actual);
        }
    }
}