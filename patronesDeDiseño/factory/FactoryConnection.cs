using System;

class FactoryConnection {
  
  public static IConnection GetConnection(string type) {
    switch (type) {
      case "MySQL":
        return new ConnectionMySQL();
      case "SQLServer":
        return new ConnectionSQLServer();
      default:
        return new UnspicifiedConnection();
    }
  }

}