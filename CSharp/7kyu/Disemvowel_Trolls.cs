using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    Regex rgx = new Regex("a|e|i|o|u|A|E|I|O|U");
    return rgx.Replace(str, "");
  }
}
