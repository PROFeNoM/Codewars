using System;
using System.Linq;
using System.Collections.Generic;
public class Kata {
  public static string Nico(string key, string m) {
      Dictionary<char, int> table = key.OrderBy(x => x).Select((x, i) => new { Item = x, Index = i }).ToDictionary(e => e.Item, e => e.Index);
      int[] coder = key.Select(e => table[e]).ToArray();
      List<char> res = new List<char>();
      for (int i = 0; i < (m.Length % key.Length == 0 ? m.Length : (m.Length/key.Length+1)*key.Length); i++)
      {
          int index = (i / key.Length)*key.Length + Array.IndexOf(coder,i%key.Length);
          if (index < m.Length)
              res.Add(m[index]);
          else
              res.Add(' ');
      }
      return String.Join("", res);
  }
}
