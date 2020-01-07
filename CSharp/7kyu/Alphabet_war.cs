using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
 {
    public static string AlphabetWar(string fight)
    {
      Dictionary<char, int> power = new Dictionary<char, int>()
      {
        { 'w', 4 },
        { 'p', 3 },
        { 'b', 2 },
        { 's', 1 },
        { 'm', -4 },
        { 'q', -3 },
        { 'd', -2 },
        { 'z', -1 },
      };
      int side_winner = fight.ToArray().Select(letter => power.ContainsKey(letter) ? power[letter] : 0).Sum();
      return side_winner > 0 ? "Left side wins!" : (side_winner < 0 ? "Right side wins!" : "Let's fight again!");
    }
 }
