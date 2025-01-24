using System;

public class Singleton
{
  // Declaración de una variable estática que contendrá la única instancia de la clase Singleton.
  // El uso de "?" indica que puede ser nula.
  private static Singleton? instance;

  // Constructor privado para evitar que se creen instancias de la clase desde fuera.
  private Singleton() { }

  // Propiedad estática que devuelve la única instancia de la clase Singleton.
  public static Singleton Instance
  {
    get
    {
      // Si la instancia es nula, se crea una nueva instancia de la clase Singleton.
      if (instance == null)
      {
        instance = new Singleton();
      }
      // Se devuelve la instancia única de la clase Singleton.
      return instance;
    }
  }

  // Método público que imprime un mensaje en la consola.
  public void Print()
  {
    Console.WriteLine("Singleton");
  }
}