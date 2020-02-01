using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static string UInt32ToIP(uint ip)
  {
    string bin = String.Concat(Enumerable.Repeat('0', 32)) + Convert.ToString(ip, 2);
    return String.Join(".", Regex.Matches(bin.Substring(bin.Length - 32), ".{8}").Select(e => Convert.ToInt32(e.ToString(), 2)));
  }
}
