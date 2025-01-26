namespace Visitor
{
  // Visitor interface
  interface IVisitor
  {
    void Visit(Book book);
    void Visit(Car car);
  }

  // Element interface
  interface IVisitable
  {
    void Accept(IVisitor visitor);
  }
}