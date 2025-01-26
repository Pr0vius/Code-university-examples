namespace Visitor
{
  class DiscountVisitor : IVisitor
  {
    public void Visit(Book book)
    {
      Console.WriteLine($"Aplicando descuento al libro: {book.Title}");
    }

    public void Visit(Car car)
    {
      Console.WriteLine($"Aplicando descuento al auto: {car.Model}");
    }
  }
}