namespace AbstractFactory
{
  public class ModernFactory : IFurnitureFactory
  {
    public IChair CreateChair()
    {
      return new ModernChair();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
      return new ModernCoffeeTable();
    }

    public ISofa CreateSofa()
    {
      return new ModernSofa();
    }
  }

  public class VictorianFactory : IFurnitureFactory
  {
    public IChair CreateChair()
    {
      return new VictorianChair();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
      return new VictorianCoffeeTable();
    }

    public ISofa CreateSofa()
    {
      return new VictorianSofa();
    }
  }

  public class ArtDecoFactory : IFurnitureFactory
  {
    public IChair CreateChair()
    {
      return new ArtDecoChair();
    }

    public ICoffeeTable CreateCoffeeTable()
    {
      return new ArtDecoCoffeeTable();
    }

    public ISofa CreateSofa()
    {
      return new ArtDecoSofa();
    }
  }
}