using System;
using System.Linq;
using System.Collections.Generic;

public class JomoPipi {

  public static string jumbledString(string s, long n) {
      string new_s = s;
      Dictionary<long, string> cycle = new Dictionary<long, string>();
      for (int i = 1; i <= n; i++)
      {
          new_s = String.Concat(new_s.Where((e, idx) => idx % 2 == 0).Concat(new_s.Where((e, idx) => idx % 2 != 0)));
          cycle.Add(i, new_s);
          if (new_s == s)
          {
              cycle.TryGetValue(n % i, out string output);
              return output == null ? s : output;
          }
      }
      return new_s;
  }
  
}
