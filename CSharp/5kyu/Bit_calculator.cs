using System;
using System.Linq;

public class Kata
{
  public static int Calculate(string num1, string num2)
  {
    return toBase10(num1) + toBase10(num2);
  }
  
  public static int toBase10(string s)
  {
    return s.Reverse().Select( (e, i) => e == '1' ? (int)Math.Pow(2, i) : 0).Sum();
  }
}
