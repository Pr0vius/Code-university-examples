public class Arreglos {
  private int[] array;
  private int count;

  public Arreglos() {
    array = new int[4];
    count = 0;
  }

  public void Add(int item) {
    if (count == array.Length) {
      int[] newArray = new int[array.Length * 2];
      for (int i = 0; i < array.Length; i++) {
        newArray[i] = array[i];
      }
      array = newArray;
    }
    array[count] = item;
    count++;
  }

  public int Get(int index) {
    if (index < 0 || index >= count) {
      throw new IndexOutOfRangeException("Index out of range");
    }
    return array[index];
  }

  public int Count {
    get { return count; }
  }
}