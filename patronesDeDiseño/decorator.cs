using System;
namespace Decorator
{// Componente base
  public interface ICoffee
  {
    string GetDescription();
    double GetCost();
  }

  // Componente concreto
  public class SimpleCoffee : ICoffee
  {
    public string GetDescription()
    {
      return "Simple coffee";
    }

    public double GetCost()
    {
      return 5.0;
    }
  }

  // Decorador base
  public abstract class CoffeeDecorator : ICoffee
  {
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
      _coffee = coffee;
    }

    public virtual string GetDescription()
    {
      return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
      return _coffee.GetCost();
    }
  }

  // Decorador concreto para agregar leche
  public class MilkDecorator : CoffeeDecorator
  {
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
      return base.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
      return base.GetCost() + 1.5;
    }
  }

  // Decorador concreto para agregar azúcar
  public class SugarDecorator : CoffeeDecorator
  {
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
      return base.GetDescription() + ", Sugar";
    }

    public override double GetCost()
    {
      return base.GetCost() + 0.5;
    }
  }

  // Ejemplo de uso
  class Program
  {
    static void Main(string[] args)
    {
      ICoffee myCoffee = new SimpleCoffee();
      Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

      myCoffee = new MilkDecorator(myCoffee);
      Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

      myCoffee = new SugarDecorator(myCoffee);
      Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");
    }
  }
}