using System;
using System.Linq;

public class Kata
{
  public static double ReduceByRules(double[] numbers, Func<double, double, double>[] rules)
  {
    var i = 0;
    return numbers.Aggregate((a,b) => rules[i++ % rules.Length](a,b));
  }
}
