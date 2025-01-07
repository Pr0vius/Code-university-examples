// Complejidad Lineal O(n)
using System;

public class EjemploComplejidadLineal
{
  // Este método toma un array de enteros y los imprime uno por uno.
  // La complejidad de este método es O(n), donde n es el número de elementos en el array.
  // Esto se debe a que el tiempo de ejecución del método crece linealmente con el tamaño del array.
  public void ImprimirElementos(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine(array[i]);
    }
  }
}