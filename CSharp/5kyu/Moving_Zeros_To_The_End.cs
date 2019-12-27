public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] result = new int[arr.Length];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] != 0)
      {
        result[index] = arr[i];
        index++;
      }
    }
    return result;
  }
}
