using System;
using System.Linq;

public class Kata
{
  public static int UniTotal(string str)
  {
    return str.Sum(i => Convert.ToInt32(i));
  }
}
