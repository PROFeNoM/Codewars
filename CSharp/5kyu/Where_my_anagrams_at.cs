using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    return words.Select(w => (String.Concat(w.OrderBy(l => l)) == String.Concat(word.OrderBy(l => l))) ? w : "").Where(w => w != "").ToList();
  }
}
