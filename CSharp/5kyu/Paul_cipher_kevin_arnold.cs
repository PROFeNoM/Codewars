using System;

namespace Kata
{
    public class PaulCipher
    {
        public static string Encode(string input) => Algo(input, 1);

        public static string Decode(string input) => Algo(input, -1);
        
        public static string Algo(string input, int orientation)
        {
            if (String.IsNullOrEmpty(input)) 
                return "";
            char[] upper_char = input.ToUpper().ToCharArray();
            int shift = 0;
            for (int i = 0; i < upper_char.Length; i++)
            {
                if (!char.IsLetter(upper_char[i])) 
                    continue;
                if (shift == 0) 
                    shift = upper_char[i];
                else
                {
                    int new_char = upper_char[i] + orientation*(shift - 64);
                    if (new_char < 'A' || new_char > 'Z') 
                        new_char -= orientation * ('Z' - 64);
                    shift = orientation > 0 ? upper_char[i] : (char)new_char;
                    upper_char[i] = (char)new_char;
                }
            }
            return new string(upper_char);
        }
    }
}
