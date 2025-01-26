namespace AbstractFactory {
  class Program {
    static void Main(string[] args) {
      IFurnitureFactory factory = new ModernFactory();
      IChair chair = factory.CreateChair();
      ISofa sofa = factory.CreateSofa();
      ICoffeeTable coffeeTable = factory.CreateCoffeeTable();

      chair.SitOn();
      sofa.Relax();
      coffeeTable.PutSomething("coffee");

      factory = new VictorianFactory();
      chair = factory.CreateChair();
      sofa = factory.CreateSofa();
      coffeeTable = factory.CreateCoffeeTable();

      chair.SitOn();
      sofa.Relax();
      coffeeTable.PutSomething("coffee");

      factory = new ArtDecoFactory();
      chair = factory.CreateChair();
      sofa = factory.CreateSofa();
      coffeeTable = factory.CreateCoffeeTable();

      chair.SitOn();
      sofa.Relax();
      coffeeTable.PutSomething("coffee");
    }
  }
}