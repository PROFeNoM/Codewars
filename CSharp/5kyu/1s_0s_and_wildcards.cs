using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public List<string> Possibilities(string input)
    {
      int n = input.Count(e => e == '?');
      var combinations = CombinationsWithRepition(new int[] {0, 1}, n);
      int seen = 0;
      for (int i = 0; i < input.Length; i++)
        if (input[i] == '?')
          input = input.Substring(0, i) + "{"+Convert.ToString(seen++)+"}" + input.Substring(i + 1);
      return combinations.Select(e => String.Format(input, e.Select(k => Convert.ToString(k)).ToArray())).ToList();
    }  
    
    static IEnumerable<String> CombinationsWithRepition(IEnumerable<int> input, int length)
    {
      if (length <= 0)
        yield return "";
      else
      {
        foreach(var i in input)
          foreach(var c in CombinationsWithRepition(input, length-1))
            yield return i.ToString() + c;
      }
    }
}
