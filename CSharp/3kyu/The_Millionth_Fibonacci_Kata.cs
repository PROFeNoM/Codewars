using System;
using System.Numerics;

public class Fibonacci
{

    public static BigInteger fib(int n)
    {
        if (n < 0)
          return (BigInteger)Math.Pow(-1, n % 2 + 1) * fib(-n);
        else
        {
          BigInteger a = 1, b = 0, p = 0, q = 1;
          while (n != 0)
          {
            if (n % 2 == 0)
            {
              BigInteger temp_p = p;
              p = p*p + q*q;
              q = q*q + 2*temp_p*q;
              n /= 2;
            }
            else
            {
              BigInteger temp_a = a;
              a = (p+q)*a + q*b;
              b = temp_a*q+b*p;
              n -= 1;
            }
          }
          return b;
        }
    }
}
