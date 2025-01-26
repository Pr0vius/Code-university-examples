using System;

namespace Adapter
{
  // Target interface
  public interface ITarget
  {
    string GetRequest();
  }

  // Adaptee class
  public class Adaptee
  {
    public string GetSpecificRequest()
    {
      return "Specific request.";
    }
  }

  // Adapter class
  public class Adapter : ITarget
  {
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
      _adaptee = adaptee;
    }

    public string GetRequest()
    {
      // Translate the request from the Adaptee to the Target interface
      return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
  }

  // Client code
  public class Client
  {
    public void Main()
    {
      Adaptee adaptee = new Adaptee();
      ITarget target = new Adapter(adaptee);

      Console.WriteLine("Client: I can work just fine with the Target objects:");
      Console.WriteLine(target.GetRequest());
    }
  }

  // Entry point
  class Program
  {
    static void Main(string[] args)
    {
      new Client().Main();
    }
  }
}