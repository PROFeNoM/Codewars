using System;
using System.Linq;
namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
      Console.WriteLine(str);
      return str == "" ? "" : string.Join("", str.Trim().Split(" ").Where(word => !string.IsNullOrWhiteSpace(word)).Select(word => char.ToUpper(word[0]) + word.Substring(1)).ToArray());
    }
  }
}

