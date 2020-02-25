using System;
using System.Linq;
using System.Collections.Generic;

class MaxSumDigits {

    public static long[] MaxSumDig(long n_max, int max_sm) 
    {
        List<long> res = new List<long>();
        
        for (long i = 1000; i < n_max + 1; i++)
        {
            bool is_good = true;
            var n = i.ToString().Select( e => e - 48);
            for (int j = 0; j < n.Count() - 3; j++)
                if (n.Skip(j).Take(4).Sum() > max_sm)
                    is_good = false;
            if (is_good == true)
                res.Add(i);
        }
        
        long num = res.Count, tot = res.Sum();
        return new long[] { num, res.OrderBy(e => Math.Abs(e - tot/(float)num)).ThenBy(e => e).First(), tot };
    }
    
}
