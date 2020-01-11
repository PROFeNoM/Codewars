using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
           return Regex.Replace(input.Replace("WUB"," "), " {2,}", " ").Trim();
        }
    }
