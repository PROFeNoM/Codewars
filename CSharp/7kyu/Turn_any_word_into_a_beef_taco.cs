 using System;
 using System.Linq;
 using System.Collections.Generic;
 
 public class Kata
 {
    public static string[] Tacofy(string word)
    {
        Console.Write(word);
        Dictionary<char, string> ingredient = new Dictionary<char, string>()
        {
          { 't', "tomato" },
          { 'l', "lettuce" },
          { 'c', "cheese" },
          { 'g', "guacamole" },
          { 's', "salsa" }
        };
        
        List<string> taco = new List<string>();
        taco.Add("shell");
        taco.AddRange(word.Select(l => ingredient.ContainsKey(Char.ToLower(l)) ? ingredient[Char.ToLower(l)] : ( "aeiouAEIOU".Contains(l) ? "beef" : "")).Where(l => l.Length > 1).ToArray());
        taco.Add("shell");
        
        return taco.ToArray();
    }
 }
