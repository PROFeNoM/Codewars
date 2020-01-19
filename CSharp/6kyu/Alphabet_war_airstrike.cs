using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
 public class Kata
 {
    public static string AlphabetWar(string fight)
    {
      Dictionary<char, int> powers = new Dictionary<char, int>()
        {
            {'w', 4}, {'m', -4},
            {'p', 3}, {'q', -3},
            {'b', 2}, {'d', -2},
            {'s', 1}, {'z', -1}
        };
      
      int res = Regex.Replace(fight, @".?\*+.?", "")
                     .ToArray()
                     .Select(e => powers.ContainsKey(e) ? powers[e] : 0)
                     .Sum();
      return res == 0 ? "Let's fight again!" : (res > 0 ? "Left side wins!" : "Right side wins!");
    }
 }
