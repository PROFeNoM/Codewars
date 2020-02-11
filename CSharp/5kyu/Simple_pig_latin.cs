using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    return String.Join(" ", str.Split(" ").Select(w => w.Length >= 2 ? w.Substring(1) + w[0] + "ay" : (char.IsPunctuation(w, 0) ? w: w + "ay")));
  }
}
