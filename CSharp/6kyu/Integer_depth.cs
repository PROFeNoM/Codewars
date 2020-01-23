using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution 
{
  public class Kata 
  {
 
    public static int ComputeDepth(int n)
    {
       int mul = 1;
       List<char> digit = new List<char>();
       int count = 0;
       while (digit.Count() < 10)
       {
         foreach (char j in (n*mul).ToString().ToCharArray().Select(e => (int)Char.GetNumericValue(e)).ToArray())
           if (!digit.Contains(j))
             digit.Add(j);
         mul++;
         count++;
       }
       return count;
    }
  
  }
}
