using System;
using System.Linq;

public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2) 
    {
        foreach (char c in str2)
            if (!(str2.Count(e => e == c) <= str1.Count(e => e == c)))
                return false;
        return true;
    }

}
