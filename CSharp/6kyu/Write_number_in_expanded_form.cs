using System;
using System.Linq;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
       return String.Join(" + ", num.ToString()
                                    .ToArray()
                                    .Reverse()
                                    .Select((x, i) => (x - 48) * Math.Pow(10, i))
                                    .Reverse()
                                    .Where(x => x != 0));
                                   
    }
}
