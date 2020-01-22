using System;
using System.Linq;

public class Kata
{
  public static bool IsHollow(int[] x)
  {
    var previously = x.TakeWhile(e => e != 0);
    var following = x.Reverse().TakeWhile(e => e!= 0);
    var middle = x.Skip(previously.Count()).Take(x.Length - following.Count() - previously.Count());
    return middle.All(e => e == 0) && middle.Count() >= 3 && previously.Count() == following.Count();
  }
}
