using System;
using System.Collections.Generic;
public class Balanced
{
    public static List<string> BalancedParens(int n)
    {
        List<string> output = new List<string>();
        void Process(int opened, int closed, string s)
        {
            if (0 < opened)
                Process(opened - 1, closed + 1, s + "(");
            if (0 < closed)
                Process(opened, closed - 1, s + ")");
            if (0 == opened + closed)
                output.Add(s);
        }
        Process(n, 0, "");
        return output;
    }
    
}
