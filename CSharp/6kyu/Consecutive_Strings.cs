using System;
using System.Linq;
using System.Collections.Generic;

public class LongestConsecutives 
{
    
    public static String LongestConsec(string[] strarr, int k) 
    {
        if (strarr.Length == 0 || k <= 0 || k > strarr.Length)
        {
          return "";
        }
        
        List<string> consec = new List<string>();  
        for (int i = 0; i < strarr.Length; i++)
        {
          if (i+k < strarr.Length)
          {
            var slice = new ArraySegment<string>(strarr, i, k);
            consec.Add(string.Join("", slice));
          }
          else
          {
            var slice = new ArraySegment<string>(strarr, i, strarr.Length-i);
            consec.Add(string.Join("", slice));
          }
        }
        consec.ToArray();
        int index_of_longest = 0;
        int length_of_longest = consec[0].Length;
        for (int i = 0; i < consec.Count; i++)
        {
          if (consec[i].Length > length_of_longest)
          {
          index_of_longest = i;
          length_of_longest = consec[i].Length;
          }
        }
        return consec[index_of_longest];
    }
}
