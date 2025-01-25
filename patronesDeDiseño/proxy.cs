using System;

// Interfaz común para RealSubject y Proxy
public interface ISubject
{
  void Request();
}

// Clase RealSubject que realiza la operación real
public class RealSubject : ISubject
{
  public void Request()
  {
    Console.WriteLine("RealSubject: Manejo de la solicitud.");
  }
}

// Clase Proxy que controla el acceso a RealSubject
public class Proxy : ISubject
{
  private RealSubject _realSubject;

  public void Request()
  {
    // Control de acceso: creación de RealSubject solo cuando sea necesario
    if (_realSubject == null)
    {
      _realSubject = new RealSubject();
    }

    Console.WriteLine("Proxy: Control de acceso antes de delegar la solicitud.");
    _realSubject.Request();
  }
}

// Cliente que utiliza la interfaz ISubject
public class Client
{
  public void ClientCode(ISubject subject)
  {
    subject.Request();
  }
}

// Ejemplo de uso del patrón Proxy
class Program
{
  static void Main(string[] args)
  {
    Client client = new Client();

    Console.WriteLine("Cliente: Ejecutando código con RealSubject:");
    RealSubject realSubject = new RealSubject();
    client.ClientCode(realSubject);

    Console.WriteLine();

    Console.WriteLine("Cliente: Ejecutando código con Proxy:");
    Proxy proxy = new Proxy();
    client.ClientCode(proxy);
  }
}