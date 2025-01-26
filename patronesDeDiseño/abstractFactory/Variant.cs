namespace AbstractFactory {
  public class ModernChair : IChair {
    public void SitOn() {
      System.Console.WriteLine("Sitting on a modern chair");
    }
  }

  public class ModernSofa : ISofa {
    public void Relax() {
      System.Console.WriteLine("Relaxing on a modern sofa");
    }
  }

  public class ModernCoffeeTable : ICoffeeTable {
    public void PutSomething(string something) {
      System.Console.WriteLine($"Putting {something} on a modern coffee table");
    }
  }

  public class VictorianChair : IChair {
    public void SitOn() {
      System.Console.WriteLine("Sitting on a victorian chair");
    }
  }

  public class VictorianSofa : ISofa {
    public void Relax() {
      System.Console.WriteLine("Relaxing on a victorian sofa");
    }
  }

  public class VictorianCoffeeTable : ICoffeeTable {
    public void PutSomething(string something) {
      System.Console.WriteLine($"Putting {something} on a victorian coffee table");
    }
  }

  public class ArtDecoChair : IChair {
    public void SitOn() {
      System.Console.WriteLine("Sitting on an art deco chair");
    }
  }

  public class ArtDecoSofa : ISofa {
    public void Relax() {
      System.Console.WriteLine("Relaxing on an art deco sofa");
    }
  }

  public class ArtDecoCoffeeTable : ICoffeeTable {
    public void PutSomething(string something) {
      System.Console.WriteLine($"Putting {something} on an art deco coffee table");
    }
  }

}