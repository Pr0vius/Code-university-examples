//Complejidad Logarítmica O(log n)
using System;

class LogarimicalExample
{
  static void Exec()
  {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int target = 7;
    int result = BinarySearch(array, target);
    Console.WriteLine(result != -1 ? $"Element found at index {result}" : "Element not found");
  }

  // Función de Búsqueda Binaria con complejidad O(log n)
  static int BinarySearch(int[] array, int target)
  {
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;

      // Verificar si el objetivo está presente en el medio
      if (array[mid] == target)
        return mid;

      // Si el objetivo es mayor, ignorar la mitad izquierda
      if (array[mid] < target)
        left = mid + 1;

      // Si el objetivo es menor, ignorar la mitad derecha
      else
        right = mid - 1;
    }

    // Objetivo no presente en el array
    return -1;
  }
}