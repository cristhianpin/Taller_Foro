using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        agregarcliente();
        consultarCliente();
        consultarClientes();
        eliminarCliente();
        modificarCliente();

        
    }

    public static void agregarcliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ClienteDBContext context = new ClienteDBContext();
        Cliente std = new Cliente();
        std.Nombre = "Pedro";
        context.Cliente.Add(std);
        context.SaveChanges();
      
        Console.WriteLine("Codigo: "+ std.ClienteId + " Nombre: "+ std.Nombre);

    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar todos los clientes");
        ClienteDBContext context = new ClienteDBContext();
        List<Cliente> listEstudiantes= context.Cliente.ToList() ;

        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.Nombre);
        }
        
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        ClienteDBContext context = new ClienteDBContext();
        Cliente std = new Cliente();
        std = context.Cliente.Find(11);

       Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);
      
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        ClienteDBContext context = new ClienteDBContext();
        Cliente std = new Cliente();
        std = context.Cliente.Find(1);

        std.Nombre = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);

    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        ClienteDBContext context = new ClienteDBContext();
        Cliente std = new Cliente();
        std = context.Cliente.Find(5);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.ClienteId + " Nombre: " + std.Nombre);

    }
  
        

    }
