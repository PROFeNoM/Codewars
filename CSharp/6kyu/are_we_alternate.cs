using System.Text.RegularExpressions;

public class Kata
{
  public static bool IsAlt(string word)
  {
    return !(Regex.IsMatch(word, "[^aeiou]{2,}|[aeiou]{2,}"));
  }
}
