class ConnectionSQLServer : IConnection
{
  public ConnectionSQLServer()
  {
  }

  public void Connect()
  {
    Console.WriteLine("Conectando a SQL Server");
  }

  public void Disconnect()
  {
    Console.WriteLine("Desconectando de SQL Server");
  }
}