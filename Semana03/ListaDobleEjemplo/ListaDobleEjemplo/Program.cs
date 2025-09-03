// See https://aka.ms/new-console-template for more information
using ListaDobleEjemplo;

Console.WriteLine("Probando la lista doble");

// Lista vacia
Lista Lista1 = new Lista();
Lista1.mostrarLista();

Console.WriteLine("\n==================");
Lista1.agregarAlUltimo("Pedro", 15);
Lista1.mostrarLista();


Console.WriteLine("\n==================");
Lista1.agregarAlUltimo("Camila", 20);
Lista1.agregarAlUltimo("Miguel", 10);
Lista1.agregarAlUltimo("Cesar", 15);
Lista1.agregarAlUltimo("Gustavo", 20);
Lista1.mostrarLista();

Console.WriteLine("\n==================");
Nodo ElMejor = Lista1.ObtenerElMejor();
if(ElMejor == null)
{
    Console.WriteLine("Lista vacia");
} else
{
    Console.WriteLine("EL MEJOR: (" + ElMejor.Nombre + "," + ElMejor.Nota + ")");
}
