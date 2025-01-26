namespace Visitor
{

  // Elemento Concreto: Libro
  class Book : IVisitable
  {
    public string Title { get; private set; }

    public Book(string title)
    {
      Title = title;
    }

    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }

  // Elemento Concreto: Auto
  class Car : IVisitable
  {
    public string Model { get; private set; }

    public Car(string model)
    {
      Model = model;
    }

    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }

  // Estructura de Objetos (Colección de elementos)
  class Store
  {
    private readonly List<IVisitable> _items = new List<IVisitable>();

    public void AddItem(IVisitable item)
    {
      _items.Add(item);
    }

    public void ApplyVisitor(IVisitor visitor)
    {
      foreach (var item in _items)
      {
        item.Accept(visitor);
      }
    }

    public class Program
    {
      public static void Main(String[] args)
      {
        Store store = new Store();
        store.AddItem(new Book("Design Patterns"));
        store.AddItem(new Car("Tesla Model S"));

        IVisitor discountVisitor = new DiscountVisitor();
        store.ApplyVisitor(discountVisitor);
      }

    }
  }
}