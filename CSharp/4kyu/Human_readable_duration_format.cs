using System;
using System.Linq;
using System.Collections.Generic;

public class HumanTimeFormat
{
  public static string formatDuration(int seconds)
  {
    Dictionary<string, int> TIMES = new Dictionary<string, int>()
    { 
                                  {"year", 365 * 24 * 60 * 60}, 
                                  {"day",        24 * 60 * 60}, 
                                  {"hour",            60 * 60},
                                  {"minute",               60},
                                  {"second",                1}
    };
    
    if (seconds == 0)
      return "now";
    
    List<string> chunks = new List<string>();
    foreach (var key_value in TIMES)
    {
      string name = key_value.Key;
      int secs = key_value.Value;    
      
      int qty = seconds / secs;
      if (qty != 0)
      {
        if (qty > 1)
          name += "s";
        chunks.Add(qty.ToString() + " " + name);
      }
      
      seconds %= secs;
    } 
    
    if (chunks.Count > 1)
      return string.Join(", ", chunks.SkipLast(1)) + " and " + chunks.Last();
    else
      return chunks[0];
  }
}
