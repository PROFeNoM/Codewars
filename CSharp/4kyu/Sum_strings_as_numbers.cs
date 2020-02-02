using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      return (BigInteger.Parse(a == "" ? "0" : a) + BigInteger.Parse(b == "" ? "0" : b)).ToString();
    }
    
    
}
