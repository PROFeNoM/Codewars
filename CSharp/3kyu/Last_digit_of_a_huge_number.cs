namespace Solution
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Collections.Generic;
    
    public class Calculator 
    {
        public static int LastDigit(int[] array)
        {
            BigInteger n = 1;
            List<int> lst = array.Reverse().ToList();
            
            foreach (int i in lst)
            {
                if (n < 4)
                    n = BigInteger.Pow(i, int.Parse(n.ToString()));
                else
                {
                    int exp = int.Parse(BigInteger.ModPow(n, 1, 4).ToString()) + 4;
                    n = BigInteger.Pow(i, exp);
                }
            }
            return (int)BigInteger.ModPow(n, 1, 10);
        }  
    }
}
