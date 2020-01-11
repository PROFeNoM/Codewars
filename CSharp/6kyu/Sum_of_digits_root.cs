using System;
using System.Linq;

public class Number
{
  public int DigitalRoot(long n)
  {
    while (n >= 10)
      n = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();
    return (int)n;
  }
}
