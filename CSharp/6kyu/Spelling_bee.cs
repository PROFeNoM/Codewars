using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Dinglemouse
{
  public static int HowManyBees(char[][] hive)
  {
    if (hive == null || hive.Length == 0)
      return 0;
    
    int horizontal = hive.Select(x => Regex.Matches(String.Join("", x), "bee").Count + Regex.Matches(String.Join("", x), "eeb").Count).Sum();
    int vertical = 0;
    string temp;
    for (int y = 0; y < hive.Max(x => x.Length); y++)
    {
      temp = "";
      foreach (char[] arr in hive)
      {
        if (arr.Length > y)
          temp += arr[y];
      }
      vertical += Regex.Matches(temp, "bee").Count + Regex.Matches(temp, "eeb").Count;
    }
    return vertical + horizontal;
  }
}
