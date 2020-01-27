using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        input = String.Join("", input.Where(e => Regex.IsMatch(e.ToString(), "[^A-Za-z]")));
        while (Regex.IsMatch(input, @"\(\)"))
            input = Regex.Replace(input, @"\(\)", "");
        return String.IsNullOrEmpty(input) ? true : false;
    }
}
