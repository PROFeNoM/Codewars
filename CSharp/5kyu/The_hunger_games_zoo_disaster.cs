using System;
using System.Linq;
using System.Collections.Generic;

public class Dinglemouse {

    public static string[] WhoEatsWho(string zoo)
    {
        Dictionary<string, string[]> eats = new Dictionary<string, string[]>()
        {
            { "antelope", new string[] { "grass" } },
            { "big-fish", new string[] { "little-fish" } },
            { "bug", new string[] { "leaves" } },
            { "bear", new string[] { "big-fish", "bug", "chicken", "cow", "leaves", "sheep" } },
            { "chicken", new string[] { "bug" } },
            { "cow", new string[] { "grass" } },
            { "fox", new string[] { "chicken", "sheep" } },
            { "giraffe", new string[] { "leaves" } },
            { "lion", new string[] { "antelope", "cow" } },
            { "panda", new string[] { "leaves" } },
            { "sheep", new string[] { "grass" } },
        };
        
        if ( zoo == "" )
            return new[] { "" };
        
        List<string> animals = zoo.Split(',').ToList();
        List<string> output = new List<string>() { zoo };
        bool is_eating = true;
        while (is_eating)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (eats.ContainsKey(animals[i]))
                {
                    if (i > 0 && eats[animals[i]].Contains(animals[i - 1]))
                    {
                        output.Add(String.Format("{0} eats {1}", animals[i], animals[i - 1]));
                        animals.RemoveAt(i - 1);
                        break;
                    }
                    if (i + 1 < animals.Count && eats[animals[i]].Contains(animals[i + 1]))
                    {
                        output.Add(String.Format("{0} eats {1}", animals[i], animals[i + 1]));
                        animals.RemoveAt(i + 1);
                        break;
                    }
                }
                if (i == animals.Count - 1)
                    is_eating = false;
            }
        }
        output.Add(String.Join(",", animals));
        return output.ToArray();
    }
    
}
