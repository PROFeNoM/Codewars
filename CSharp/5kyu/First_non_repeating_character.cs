using System;
using System.Linq;

public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    return String.IsNullOrEmpty(s) ? "" : s.Where(c => s.Count(e => Char.ToLower(e) == Char.ToLower(c)) == 1).Select(c => c.ToString()).DefaultIfEmpty(String.Empty).FirstOrDefault();
  }
}
