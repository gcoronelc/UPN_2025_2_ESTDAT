// See https://aka.ms/new-console-template for more information
using Programa01;

Console.WriteLine("Hello, World!");

Lista lista = new Lista();

Console.WriteLine("Tamaño inicial: " + lista.Contador);
lista.mostrarLista();
Console.WriteLine("Suma: " + lista.sumar());
Console.WriteLine("Promedio: " + lista.promediar());
Console.WriteLine("=====================================");
lista.nuevoNodo(30);
lista.nuevoNodo(60);
lista.nuevoNodo(50);
lista.nuevoNodo(20);
Console.WriteLine("Tamaño final: " + lista.Contador);
lista.mostrarLista();
Console.WriteLine("Suma: " + lista.sumar());
Console.WriteLine("Promedio: " + lista.promediar());
