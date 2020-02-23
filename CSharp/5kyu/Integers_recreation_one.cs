using System;

public class SumSquaredDivisors 
{
	public static string listSquared(long m, long n)
	{
		string res = "[";
    for (var i = m; i <= n; i++)
    {
      int temp = 0;
      for (var j = 1; j <= i; j++)
        if (i % j == 0)
          temp += j * j;
      if (Math.Sqrt(temp) % 1 == 0)
      {
        if (res.Length > 1)
          res += String.Format(", [{0}, {1}]", i, temp);
        else
          res += String.Format("[{0}, {1}]", i, temp);
      }
    }
    return res + "]";
	}
}
