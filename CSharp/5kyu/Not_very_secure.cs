using System.Text.RegularExpressions;

public class Kata
{
  public static bool Alphanumeric(string str) => Regex.IsMatch(str, "^[a-zA-Z0-9]+$");
}
