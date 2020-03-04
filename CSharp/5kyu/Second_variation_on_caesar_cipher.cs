using System;
using System.Linq;
using System.Collections.Generic;
public class CaesarTwo
        {			
            public static List<string> encodeStr(string s, int shift)
            {
                Console.WriteLine(s);
                shift %= 25;
                string res = Convert.ToString(Char.ToLower(s[0])) + Char.ToLower(Convert.ToChar(s[0] + shift)) + coder(s, shift);
                int part = res.Length / 5;
                if (res.Length % 5 != 0)
                    part += 1;
                List<string> output = Enumerable.Range(0, 5).Select( i => String.Join("", res.Skip(i * part).Take(part) ) ).ToList();
                if (output[4] == "")
                    output.RemoveAt(output.Count() - 1);
                return output;
            }
			
			      public static string decode(List<string> s_arr)
            {
                string s = String.Join("", s_arr);
                int shift = s[0] - s[1];
                return coder(s.Substring(2), shift);
            }
            
            public static string coder(string s, int shift)
            {
                string output = "";
                foreach (char c in s)
                {
                    if ( (c == 'z' || c == 'Z') && shift > 0)
                        output += (c == 'z' ? 'a' : 'A');
                    else if ( (c == 'a' || c == 'A') && shift < 0)
                        output += (c == 'a' ? 'z' : 'Z');
                    else
                        output += (Char.IsLetter(c) ? Convert.ToChar(c + shift): c);
                }
                return output;
            }
        }
