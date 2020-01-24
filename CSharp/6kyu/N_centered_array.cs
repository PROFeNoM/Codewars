using System;
using System.Linq;
public static class Kata
{
  public static bool IsCenteredN(int[] arr, int n)
  {
    return Enumerable.Range(0, arr.Length/2 + 1).Select(e => arr.Skip(e).SkipLast(e).Sum() == n).Any(x => x) || arr.Sum() == n;
  }
}
