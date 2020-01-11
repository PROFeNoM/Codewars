using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
     Regex rgx = new Regex("(:|;)(-|~)?([)]|D)");
     return smileys.Select(s => rgx.IsMatch(s)).Count(s => s);
  }
}
