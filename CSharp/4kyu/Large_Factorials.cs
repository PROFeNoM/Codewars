using System;

public class Kata
{
  public static string Factorial(int n)
  {
    if (n < 0)
    {
      return null;
    }
    
    int[] res = new int[500];
    res[0] = 1;
    int res_size = 1;
    string fact = "";
    for (int i = 2; i <= n; i++)
    {
      int carry = 0;
      for (int j = 0; j < res_size; j++)
      {
        int prod = res[j] * i + carry;
        res[j] = prod % 10;
        carry = prod / 10;
      }
      while (carry != 0)
      {
        res[res_size] = carry % 10;
        carry /= 10;
        res_size++;
      }
    }
    for (int i = res_size - 1; i >= 0; i--) 
			fact += res[i]; 
    return fact;
  }
}
