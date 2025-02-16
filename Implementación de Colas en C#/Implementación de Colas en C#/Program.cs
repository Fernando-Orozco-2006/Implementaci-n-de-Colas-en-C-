using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> colaClientes = new Queue<string>();
        int opcion;

        do
        {
            Console.WriteLine("\nSistema de Atención de Clientes");
            Console.WriteLine("1. Agregar cliente a la cola");
            Console.WriteLine("2. Atender cliente");
            Console.WriteLine("3. Mostrar estado de la cola");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Favor de ingresar el nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        colaClientes.Enqueue(cliente);
                        Console.WriteLine($"El cliente {cliente} es agregado a la cola.");
                        break;

                    case 2:
                        if (colaClientes.Count > 0)
                        {
                            string clienteAtendido = colaClientes.Dequeue();
                            Console.WriteLine($"El cliente {clienteAtendido} ha sido atendido.");
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes en la cola.");
                        }
                        break;

                    case 3:
                        if (colaClientes.Count > 0)
                        {
                            Console.WriteLine("Clientes en la cola:");
                            foreach (var c in colaClientes)
                            {
                                Console.WriteLine("- " + c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("La opción no es válida, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Favor de ingresar una opción válida.");
            }
        } while (opcion != 4);
    }
}
