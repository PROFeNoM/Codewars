using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    return 4 * fib(n).Aggregate(BigInteger.Add);
  }
  
  public static List<BigInteger> fib(BigInteger n) 
  {
    List<BigInteger> fib_seq = new List<BigInteger> { 0, 1 };
    while (fib_seq.Count() < n + 2)
      fib_seq.Add(fib_seq[fib_seq.Count() - 1] + fib_seq[fib_seq.Count() - 2]);
    return fib_seq;
  }
}
