using System;

namespace DependencyInjection
{// Interfaz del servicio
  public interface IServicio
  {
    void Ejecutar();
  }

  // Implementación concreta del servicio
  public class Servicio : IServicio
  {
    public void Ejecutar()
    {
      Console.WriteLine("Servicio ejecutado.");
    }
  }

  // Clase que depende del servicio
  public class Cliente
  {
    private readonly IServicio _servicio;

    // Constructor que recibe la dependencia a través de la inyección de dependencias
    public Cliente(IServicio servicio)
    {
      _servicio = servicio;
    }

    public void EjecutarServicio()
    {
      _servicio.Ejecutar();
    }
  }

  // Clase principal para ejecutar el ejemplo
  public class Program
  {
    public static void Main(string[] args)
    {
      // Crear una instancia del servicio
      IServicio servicio = new Servicio();

      // Inyectar la dependencia en el cliente
      Cliente cliente = new Cliente(servicio);

      // Ejecutar el método del cliente que utiliza el servicio
      cliente.EjecutarServicio();
    }
  }
}