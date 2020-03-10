using System;
using System.Linq;

public class Kata
{
    public static string MixedFraction(string s)
    {
        int[] num_den = s.Split('/').Select(e => Convert.ToInt32(e)).ToArray();
        int num = num_den[0], den = num_den[1];
        if (den == 0) throw new DivideByZeroException();
        if (num % den == 0) return "" + num/den;
        int common_den = gcd(num, den);
        string sign = (double)num / den < 0 ? "-" : "";
        num = Math.Abs(num / common_den);
        den = Math.Abs(den / common_den);
        return sign + (num < den ? "" : num / den + " ") + num % den + "/" + den;
    }
  
    public static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b);
}
