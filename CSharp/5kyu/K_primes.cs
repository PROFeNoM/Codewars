using System;
using System.Linq;
using System.Collections.Generic;

public class KPrimes 
{

    public static long[] CountKprimes(int k, long start, long end) 
    {
    
        if (start > end || k < 1)
            return new long[0];
        List<long> res = new List<long>();
        for (long i = start; i <= end; i++)
            if (CountPrimes(i) == k)
                res.Add(i);
        return res.ToArray();
           
    }
    
    public static int CountPrimes(long n) 
    {
    
        int i = 2;
        int count = 0;
        while (i * i <= n)
        {
            while (n % i == 0)
            {
                n /= i;
                count++;
            }
            i++;
        }
        if (n != 1)
            count++;
        return count;
    
    }
    
    public static int Puzzle(int s) 
    {
    
        long sl = (long)s;
        long[] one_prime = CountKprimes(1, 2, sl); // 2**1
        long[] three_prime = CountKprimes(3, 8, sl); // 2**3
        long[] seven_prime = CountKprimes(7, 128, sl); // 2**7
        int res = 0;
        for (int a = 0; a < one_prime.Length; a++)
            for (int b = 0; b < three_prime.Length; b++)
            {
                long sum = one_prime[a] + three_prime[b];
                if (seven_prime.Contains(sl - sum))
                    res++;
            }
        return res;
    
    }
    
}
