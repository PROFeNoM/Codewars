using System;
using System.Linq;
using System.Collections.Generic;
public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    var res = signature.ToList();
    while (res.Count < n)
      res.Add(res.Skip(res.Count - 3).Sum());
    return res.GetRange(0, n).ToArray();
  }
}
