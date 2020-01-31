using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class Dinglemouse {

  public static Dictionary<char, char> table = new Dictionary<char, char> 
            {
              {'b','1'},{'f','1'},{'p','1'}, {'v','1'},
              {'c','2'},{'g','2'},{'j','2'},{'k','2'},{'q','2'},{'s','2'},{'x','2'}, {'z','2'},
              {'d','3'},{'t','3'},
              {'l','4'},
              {'m','5'},{'n','5'},
              {'r','6'}
            };
  
  public static string Soundex(string names) {
    return String.Join(" ", names.Split(" ").Select(s => ProcessString(s).ToUpper()));
  }
  
  public static string ProcessString(string s) {
    char f1 = s[0];
    
    s = s.ToLower();
    
    s = s[0].ToString() + Regex.Replace(s.Substring(1), "[hw]", "");
    
    s = String.Join("", s.Select(e => table.ContainsKey(e) ? table[e] : e));
    
    s = Regex.Replace(s, @"(\d)(\1)+", m => m.Value[0].ToString());
    
    s = s[0].ToString() + Regex.Replace(s.Substring(1), "[aeiouy]", "");
    
    if (Char.IsNumber(s[0]))
      s = f1 + s.Substring(1);
    
    return Regex.Matches(s, @"\d").Count() < 3 ? (s + "000").Substring(0, 4) : s.Substring(0, 4);
  }

}
