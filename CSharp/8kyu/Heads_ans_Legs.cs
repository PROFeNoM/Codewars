using System;

public class Kata
{
  public static object Animals(int heads, int legs)
  {
    /* 
    By solving the system: (cows, chikens) E N^2
      2*chickens + 4*cows = legs
        chickens +   cows = head
    We come to the solution:
      cows = 1/2 * legs - head
      chicken = 2 * head - 1/2 legs
    */
    var cows = 0.5 * legs - heads; 
    var chicken = 2 * heads - 0.5 * legs;
    if (cows == Math.Round((double)cows, 0) && chicken == Math.Round((double)chicken, 0) && cows >= 0 && chicken >= 0)
      return new int[] { (int)chicken, (int)cows };
    else
      return "No solutions";
  }
}
