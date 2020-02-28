using System;
using System.Linq;
using System.Collections.Generic;

public class RemovedNumbers {
	  public static List<long[]> removNb(long n) {
		    List<long[]> res = new List<long[]>();
        long sum = n * (n + 1) / 2;
        for (long a = 1; a <= n; a++)
        {
            double b = (double)(sum - a) / (a + 1);
            if (b % 1 == 0 && b <= n)
                res.Add(new long[] { a, (long)b });
        }
        
        return res.OrderBy(e => e[0]).ToList();
	  }
}
