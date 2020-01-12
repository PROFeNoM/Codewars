using System;
using System.Linq;

public class Kata
{
  public static string SortTheInnerContent(string words)
  {
    return String.Join(" ", words.Split(" ").Select(i => i.Length > 3 ? (i[0] + String.Join("", String.Concat(i.Substring(1, i.Length - 2).OrderByDescending(c => c).ToArray())) + i[i.Length - 1]) : i));
  }
}
