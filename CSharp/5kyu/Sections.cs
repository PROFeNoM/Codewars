using System;

class Section
{
  public static int C(long k)
  {
      double sqrt = Math.Sqrt(k);
      if ((int)sqrt != sqrt)
          return 0;
      int cnt = 1;
      for (long i = 2; i <= sqrt; i++)
      {
          if (sqrt % i != 0)
              continue;
          int div = 0;
          while (sqrt % i == 0)
          {
              sqrt /= i;
              div++;
          }
          cnt *= ((div - 1) * 3) + 4;
      }
      return cnt;
  }
}
