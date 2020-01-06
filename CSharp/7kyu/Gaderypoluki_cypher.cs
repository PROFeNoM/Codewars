  using System;
  using System.Linq;
  using System.Collections.Generic; 
  
  
  public  class Kata
  {
        public static string Encode(string str)
        {           
              Dictionary<char, char> substitution = new Dictionary<char, char>()
            {
                {'A', 'G'},
                {'a', 'g'},
                {'E', 'D'},
                {'e', 'd'},
                {'Y', 'R'},
                {'y', 'r'},
                {'O', 'P'},
                {'o', 'p'},
                {'U', 'L'},
                {'u', 'l'},
                {'I', 'K'},
                {'i', 'k'},
                {'G', 'A'},
                {'g', 'a'},
                {'D', 'E'},
                {'d', 'e'},
                {'R', 'Y'},
                {'r', 'y'},
                {'P', 'O'},
                {'p', 'o'},
                {'L', 'U'},
                {'l', 'u'},
                {'K', 'I'},
                {'k', 'i'}
            };
            return string.Join("", str.Select(x => substitution.ContainsKey(x) ? substitution[x] : x).ToArray());
        }

        public static string Decode(string str)
        {
            return Encode(str);
        }
  }
