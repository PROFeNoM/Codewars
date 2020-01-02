public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    int dynamic_index = 0;
    while (dynamic_index < arr.Length - 1 && arr[dynamic_index] == arr[dynamic_index + 1] - 1)
      dynamic_index++;
    if (dynamic_index == arr.Length - 1)
      return null;
    else
      return arr[dynamic_index + 1];
  }
}
