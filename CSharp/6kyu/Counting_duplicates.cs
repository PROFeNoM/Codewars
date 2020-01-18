using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Kata
{
  public static int DuplicateCount(string str)
  {
    return Regex.Matches(String.Concat(str.ToLower().OrderBy(c => c)), "(.)\\1+").Count();
  }
}
