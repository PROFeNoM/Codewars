namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Kata
    {
        public int[] WeakNumbers(int n)
        {
          List<int> divisors = new List<int>();
          int weakest = 0, cnt = 0;
          for (int x = 1; x <= n; x++)
          {
              int d = NumbersOfDivisors(x);
              int weakness = divisors.Count(e => e > d);
              divisors.Add(d);
              if (weakness > weakest)
              {
                  weakest = weakness;
                  cnt = 1;
              }
              else if (weakness == weakest)
                  cnt++;
          }
          return new int[] { weakest, cnt };
          
        }
        
        public int NumbersOfDivisors(int n)
        {
            int output = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    if (n / i == i)
                        output++;
                    else
                        output += 2;
                }
            return output;
        }
    }
}
