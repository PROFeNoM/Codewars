using System;
using System.Linq;
using System.Collections.Generic;

public class Johnann {
    
    public static List<long> Generation(long day, string name) {
        Dictionary<string, List<int>> person = new Dictionary<string, List<int>>(){ 
                                                { "ann", new List<int>() { 1, 1 } }, 
                                                { "john", new List<int>() { 0, 0 } } 
                                            };
        Dictionary<string, string> other = new Dictionary<string, string>(){
                                               { "ann", "john" },
                                               { "john", "ann" },
                                           };
        for (int n = 2, t = person[name][n - 1]; n < day; n++, t = person[name][n - 1])
        {
            if (t >= person[other[name]].Count())
                person[other[name]].Add(t - person[name][person[other[name]][t - 1]]);
            person[name].Add(n - person[other[name]][t]);
        }
        return person[name].Take((int)(day + 1)).Select(e => (long)e).ToList();
    }
    
    public static List<long> John(long day) {
        return Generation(day, "john");
    }
    public static List<long> Ann(long day) {
        return Generation(day, "ann");
    }
    public static long SumJohn(long n) {
        return John(n).Sum();
    }
    public static long SumAnn(long n) {
        return Ann(n).Sum();
    }
}
