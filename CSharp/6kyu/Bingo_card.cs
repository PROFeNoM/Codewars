using System;
using System.Linq;
using System.Collections.Generic;

public class BingoCard
{
    public static string[] GetCard()
    {
        var BINGO = new List<List<object>>()
        {
            new List<object>(){"B", Tuple.Create(1 , 15), 5},
            new List<object>(){"I", Tuple.Create(16, 30), 5},
            new List<object>(){"N", Tuple.Create(31, 45), 4},
            new List<object>(){"G", Tuple.Create(46, 60), 5},
            new List<object>(){"O", Tuple.Create(61, 75), 5},
        };
        
        var res = BINGO.Select(e => Gen((Tuple<int, int>)e[1], (int)e[2]).Select(n => (string)e[0] + n).ToArray()).ToArray();
        return res[0].Concat(res[1]).Concat(res[2]).Concat(res[3]).Concat(res[4]).ToArray();
    }
    
    public static string[] Gen(Tuple<int, int> range, int limit)
    {
        Random rnd = new Random();
        List<string> nums = new List<string>();
        List<int> used = new List<int>();
        while (nums.Count() != limit)
        {
            int n = rnd.Next(range.Item1, range.Item2);
            if (!used.Contains(n))
            {
                nums.Add(Convert.ToString(n));
                used.Add(n);
            }
        }
        return nums.ToArray();
    }
}
