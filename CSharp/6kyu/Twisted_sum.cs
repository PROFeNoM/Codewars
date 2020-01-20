using System;
using System.Linq;
public class TwistedSum
{
  public static long Solution(long n)
  {
	  return Enumerable.Range(1, (int)n).Select(num => num.ToString().Select(x => x - 48).Sum()).Sum();
  }
}
