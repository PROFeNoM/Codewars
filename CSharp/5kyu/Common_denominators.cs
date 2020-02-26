using System;
using System.Linq;
using System.Collections.Generic;

public class Fracts {
  public static string convertFrac(long[,] lst) {
    long cmn_dem = 1;
    for (int i = 0; i < lst.GetLength(0); i++)
        cmn_dem = lcm(cmn_dem, lst[i, 1]);
    List<string> res = new List<string>();
    for (int i = 0; i < lst.GetLength(0); i ++)
        res.Add(String.Format("({0},{1})", lst[i, 0] * cmn_dem / lst[i, 1], cmn_dem));
    return String.Join("", res);
  }
  
  public static long gcd(long a, long b) => a < b ? gcd(b, a) : ( b == 0 ? a : gcd(b, a % b) );
  
  public static long lcm(long a, long b) => a * (b / gcd(a, b));
}
