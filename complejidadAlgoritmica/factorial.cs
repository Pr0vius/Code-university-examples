// Complejidad factorial O(n!)
using System;

class FactorialExample
{
  // Método para calcular el factorial de un número
  static long Factorial(int n)
  {
    // Caso base: si n es 0 o 1, el factorial es 1
    if (n <= 1)
      return 1;

    // Llamada recursiva para calcular el factorial de n-1
    return n * Factorial(n - 1);
  }

  static void Exec()
  {
    int number = 5; // Puedes cambiar este valor para probar con otros números
    long result = Factorial(number);
    Console.WriteLine($"El factorial de {number} es {result}");
  }
}