using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static int Solve(string s)
    {
        return String.IsNullOrEmpty(s) ? 0 : Regex.Matches(s, "[^aeiou]+", RegexOptions.IgnoreCase).Select(i => i.ToString().Sum(e => e - 96)).Max();
    }
}
