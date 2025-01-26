namespace AbstractFactory
{
    public interface IChair
    {
        void SitOn();
    }

    // Producto base para Sofá
    public interface ISofa
    {
        void Relax();
    }

    // Producto base para Mesilla
    public interface ICoffeeTable
    {
        void PutSomething(string something);
    }

    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
}