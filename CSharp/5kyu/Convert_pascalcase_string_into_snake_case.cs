using System;
using System.Text.RegularExpressions;

public static class Kata 
{
  public static string ToUnderscore(int str) => Convert.ToString(str);
  
  public static string ToUnderscore(string str) => String.Join("_", Regex.Split(str.Trim(), @"(?=[A-Z])") ).ToLower().Substring(1);
}
