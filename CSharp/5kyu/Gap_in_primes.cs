using System;

class GapInPrimes 
{
    public static long[] Gap(long g, long m, long n) 
    {
        long prev_prime = 0;
        for (long i = m; i < n; i++)
            if (isPrime(i))
            {
                if (prev_prime == 0)
                    prev_prime = i;
                else if (i - prev_prime == g)
                    return new long[] { prev_prime, i };
                else
                    prev_prime = i;
            }
        return null;
    }        
    
    public static bool isPrime(long n) 
    {
        for (long i = 2; i < Math.Sqrt(n) + 1; i++)
            if (n % i == 0)
                return false;
        return true;
    }   
}
