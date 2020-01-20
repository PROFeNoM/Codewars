using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Plugboard {
  Dictionary<char, char> pairs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToDictionary(k => k, v => v);
  public Plugboard(String wires = "") {
    if (wires.Length % 2 != 0 || wires.Length > 20 || wires.Distinct().Count() != wires.Length)
      throw new ArgumentException();
    foreach (var p in Regex.Matches(wires, ".{2}"))
    {
      pairs[p.ToString()[0]] = p.ToString()[1];
      pairs[p.ToString()[1]] = p.ToString()[0];
    }
    
  }
  public char process(char c) {
    return pairs.ContainsKey(c) ? pairs[c] : c;
  }
}
