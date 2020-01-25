using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<char> Remember(string str)
  {
    List<char> res = new List<char>();
    List<char> detected = new List<char>();
    foreach(char c in str)
    {
      if (detected.Contains(c) && !res.Contains(c))
        res.Add(c);
      detected.Add(c);
    }
    return res;
  }
}
