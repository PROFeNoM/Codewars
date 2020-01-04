using System;
using System.Linq;

public class Kata
{
  public static int[] SortByValueAndIndex(int[] array)
  {
    return array.Select((num, idx) => new int[] { num, idx }).OrderBy(arr => arr[0] * (arr[1] + 1)).Select(arr => arr[0]).ToArray();
  }
}
