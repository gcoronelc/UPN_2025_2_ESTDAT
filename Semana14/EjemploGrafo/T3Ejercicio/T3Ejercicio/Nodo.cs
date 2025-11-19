using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3Ejercicio
{
    public class Nodo
    {
        public string Ciudad { get; set; }
        public List<Nodo> ListAdyacentes { get; set; }
        public Nodo(string nombre)
        {
            Ciudad = nombre;
            ListAdyacentes = new List<Nodo>();
        }
        public void AgregarAdyacente(Nodo nodo)
        {
            ListAdyacentes.Add(nodo);
        }
        public override string ToString()
        {
            return Ciudad;
        }
    }
}
