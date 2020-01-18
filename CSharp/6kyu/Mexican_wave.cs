using System;
using System.Collections.Generic;
namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
              if (!(Char.IsUpper(str[i])) && str[i] != ' ')
                res.Add(str.Substring(0, i) + Char.ToUpper(str[i]) + str.Substring(i+1));
            }
            return res;
        }
    }
}
