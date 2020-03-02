using System;
using System.Linq;
using System.Collections.Generic;

public class Kata 
{
    public static string HamsterMe(string code, string message) 
    {
        List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToList();
        
        string sorted_code = String.Join("", code.Distinct().OrderBy(x => x));
        
        List<List<char>> table = new List<List<char>>();
        foreach (char c in sorted_code)
            table.Add( new List<char> { c } ); 
        
        for (int i = 0; i < table.Count - 1; i++)
        {
            int j = alphabet.IndexOf(table[i][0]);
            alphabet.RemoveAt(j);
            while (alphabet[j] != table[i + 1][0])
            {
                table[i].Add(alphabet[j]);
                alphabet.RemoveAt(j);
                if (j >= alphabet.Count)
                    j = 0;
            }
        }
        int t = alphabet.IndexOf(table.Last().First());
        alphabet.RemoveAt(t);
        table[table.Count - 1].AddRange(alphabet.Skip(t));
        table[table.Count - 1].AddRange(alphabet.Take(t));

        Dictionary<char, string> key = new Dictionary<char,string>();
        foreach (List<char> lst in table)
            for (int i = 0; i < lst.Count; i++)
                key.Add(lst[i], lst[0] + (i + 1).ToString());
        
        
        return String.Join("", message.Select(e => key[e]));
    }
}
