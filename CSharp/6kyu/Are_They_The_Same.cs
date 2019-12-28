using System;
using System.Linq;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if (a == null || b == null)
    {
      return false;
    }
    else if (a.Length == 0 && b.Length == 0)
    {
      return true;
    }
    else
    {
      for (int i = 0; i < a.Length; i++)
      {
        a[i] = a[i] * a[i];
      }
      Array.Sort(a);
      Array.Sort(b);
      if (a.SequenceEqual(b))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
