using System;

public static class Kata 
{
  public static int TrailingZeros(int n)
  {
    int res = 0;
    while (n > 0)
    {
      n /= 5; 
      res += n;
    }
    return res;
  }
}
