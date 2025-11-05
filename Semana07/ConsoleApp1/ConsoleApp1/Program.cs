using System;
using System.Collections.Generic;
class Cliente
{
    public int Id { get; set; }
    public DateTime HoraLlegada { get; set; }
    public DateTime HoraInicioAtencion { get; set; }
    public DateTime HoraSalida { get; set; }
    public double TiempoEspera => (HoraInicioAtencion - HoraLlegada).TotalSeconds;
    public double TiempoEnSistema => (HoraSalida - HoraLlegada).TotalSeconds;
}
class Program
{
    // Muestra cómo generar exponenciales con media "meanSeconds"
    static double SampleExponential(Random rnd, double meanSeconds)
    {
        // meanSeconds = media (E = 1/λ). Retorna valor en segundos.
        double u = rnd.NextDouble();
        return -meanSeconds * Math.Log(1 - u);
    }
    static void Main()
    {
        Queue<Cliente> cola = new Queue<Cliente>();
        List<Cliente> atendidos = new List<Cliente>();
        Random rnd = new Random();
        int contador = 0;
        // Parámetros (en segundos)
        double meanInterArrival = 5.0; // media tiempo entre llegadas (segundos)
        double meanService = 4.0; // media tiempo de servicio (segundos)
        DateTime relojSimulado = DateTime.Now; // tiempo inicial simulado
        DateTime servidorLibre = relojSimulado; // momento en que el servidor queda libre
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== SIMULACIÓN DE COLA (MODO SIMULADO) ===");
            Console.WriteLine($"Reloj simulado: {relojSimulado:T} | Servidor libre:{ servidorLibre: T}");
        Console.WriteLine("1. Ingresar cliente (se genera interarrival)");
            Console.WriteLine("2. Atender siguiente cliente");
            Console.WriteLine("3. Mostrar estado de la cola");
            Console.WriteLine("4. Mostrar estadísticas (atendidos)");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = 0;
            switch (opcion)
            {
                case 1:
                    // Generar tiempo entre llegadas (exponencial) y avanzar reloj simulado
                    double interArrival = SampleExponential(rnd, meanInterArrival);
                    relojSimulado = relojSimulado.AddSeconds(interArrival);
                    contador++;
                    var nuevo = new Cliente
                    {
                        Id = contador,
                        HoraLlegada = relojSimulado
                    };
                    cola.Enqueue(nuevo);
                    Console.WriteLine($"\nCliente {nuevo.Id} llegó a las {nuevo.HoraLlegada:T}(Δ ={ interArrival: F2}s).");
            break;
                case 2:
                    if (cola.Count == 0)
                    {
                        Console.WriteLine("\nNo hay clientes en la cola.");
                    }
                    else
                    {
                        var c = cola.Dequeue();
                        // Inicio de atención = cuando el cliente llega o cuando el servidor quede libre
                        c.HoraInicioAtencion = servidorLibre > c.HoraLlegada ? servidorLibre :
                        c.HoraLlegada;
                        // Generar tiempo de servicio exponencial
                        double serviceTime = SampleExponential(rnd, meanService);
                        c.HoraSalida = c.HoraInicioAtencion.AddSeconds(serviceTime);
                        // Actualizar servidor libre
                        servidorLibre = c.HoraSalida;
                        atendidos.Add(c);
                        Console.WriteLine($"\nCliente {c.Id} atendido:");
                        Console.WriteLine($" Llegada: {c.HoraLlegada:T}");
                        Console.WriteLine($" Inicio: {c.HoraInicioAtencion:T} (espera:{ c.TiempoEspera:F2}s)");
                    Console.WriteLine($" Salida: {c.HoraSalida:T} (servicio:{ serviceTime: F2}s)");
                    }
                    break;
                case 3:
                    Console.WriteLine("\nClientes en cola (orden FIFO):");
                    if (cola.Count == 0) Console.WriteLine(" La cola está vacía.");
                    else
                        foreach (var e in cola)
                            Console.WriteLine($" Cliente {e.Id} - Llegó: {e.HoraLlegada:T}");
                    break;
                case 4:
                    Console.WriteLine("\n=== Estadísticas de atendidos ===");
                    if (atendidos.Count == 0) Console.WriteLine(" No se ha atendido a nadie aún.");
                    else
                    {
                        Console.WriteLine("ID | Llegada | Inicio | Salida | Espera(s) | Total(s)");
                        Console.WriteLine("---------------------------------------------------------- - ");
                        double sumaEspera = 0, sumaTotal = 0;
                        foreach (var x in atendidos)
                        {
                            sumaEspera += x.TiempoEspera;
                            sumaTotal += x.TiempoEnSistema;
                            Console.WriteLine($"{x.Id,2} | {x.HoraLlegada:T} |{ x.HoraInicioAtencion:T} | { x.HoraSalida:T} | { x.TiempoEspera,8:F2} | { x.TiempoEnSistema,8:F2}");
                        }
                        Console.WriteLine("---------------------------------------------------------- - ");
                        Console.WriteLine($"Promedio espera: {sumaEspera / atendidos.Count:F2} s");
                        Console.WriteLine($"Promedio total: {sumaTotal / atendidos.Count:F2} s");
                    }
                    break;
                case 5:
                    Console.WriteLine("\nSaliendo...");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida.");
                    break;
            }
            if (opcion != 5)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 5);
    }
}
