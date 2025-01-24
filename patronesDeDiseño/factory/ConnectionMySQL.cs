class ConnectionMySQL : IConnection
{
  public ConnectionMySQL()
  {
  }

  public string description()
  {
    return "Conexión MySQL";
  }
  public void Connect()
  {
    Console.WriteLine("Conectando a MySQL");
  }

  public void Disconnect()
  {
    Console.WriteLine("Desconectando de MySQL");
  }
}