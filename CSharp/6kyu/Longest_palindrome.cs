using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetLongestPalindrome(string str)
  {
    if (str == null)
      return 0;
    int len = 0;
    string word = "";
    for (int x = 1; x < str.Length + 1; x++)
    {
      for (int pos = 0; pos < str.Length - x + 1; pos++)
      {
        word = str.Substring(pos, x);
        if (word == new string(word.Reverse().ToArray()))
          len = x;
      }
    }
    return len;
  }
}
