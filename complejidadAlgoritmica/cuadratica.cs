// Complejidad cuadrática O(n^2)
using System;

class CuadraticExample
{
  static void Exec()
  {
    int n = 5; // Puedes cambiar el valor de n para probar con diferentes tamaños de entrada
    Cuadratica(n);
  }

  static void Cuadratica(int n)
  {
    // Iteramos sobre cada elemento del arreglo
    for (int i = 0; i < n; i++)
    {
      // Para cada elemento, iteramos sobre todos los elementos nuevamente
      for (int j = 0; j < n; j++)
      {
        // Aquí puedes realizar alguna operación, por ejemplo, imprimir los índices
        Console.WriteLine($"i: {i}, j: {j}");
      }
    }
  }
}