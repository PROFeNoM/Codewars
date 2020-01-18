using System;
using System.Linq;
using System.Collections; 
public class Kata
{
  public static int[] SortArray(int[] array)
  {
    var odds = new Stack(array.Where(x => x%2 != 0).OrderByDescending(c => c).ToArray());
    return array.Select(x => x%2 != 0 ? (int)odds.Pop() : x).ToArray();
  }
}
