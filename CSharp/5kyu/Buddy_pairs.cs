using System;
class Bud
{
	  public static string Buddy(long start, long limit)
	  {
		    for (long n = start; n <= limit; n++)
        {
            long possibility = DivisorsSum(n) - 1;
            if (possibility < n) continue;
            if (DivisorsSum(possibility) == n + 1)
                return $"({n} {possibility})";
        }
        return "Nothing";
	  }
    
    public static long DivisorsSum(long n)
	  {
		    long output = 1;
        for (long i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
            {
                output += i;
	              long div_pair = n / i;
                if (div_pair != i) output += div_pair;
            }
        return output;
    }        
}
