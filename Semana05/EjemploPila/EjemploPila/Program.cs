// See https://aka.ms/new-console-template for more information
using EjemploPila;

Console.WriteLine("Hello, World!");

Pila NuevaPila = new Pila();
Console.WriteLine("Pila vacía: " + NuevaPila.EstaVacia());

NuevaPila.Push("samuel");
NuevaPila.Push("Ikher");
NuevaPila.Push("Fabrizio");
NuevaPila.Push("Perchy");
Console.WriteLine("Pila vacía: " + NuevaPila.EstaVacia());
NuevaPila.Mostrar();

Console.WriteLine(" *****************************");
Console.WriteLine(NuevaPila.Pop());
Console.WriteLine(NuevaPila.Pop());
Console.WriteLine(NuevaPila.Pop());
Console.WriteLine(NuevaPila.Pop());
Console.WriteLine(NuevaPila.Pop());
NuevaPila.Push("tefo ");
Console.WriteLine(NuevaPila.Pop());
Console.WriteLine(NuevaPila.Pop());

Console.WriteLine(" *****************************");
Console.WriteLine(NuevaPila.Peek());
NuevaPila.Push("samuel");
NuevaPila.Push("sebastian");
NuevaPila.Push("moises");
Console.WriteLine(NuevaPila.Peek());
Console.WriteLine(NuevaPila.Peek());