using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static bool IsBalanced(string s, string caps)
    {
        List<int> stack = new List<int>();
        int index;
        foreach (char c in s)
        {
            index = caps.IndexOf(c);
            if (index == -1)
                continue;
            else if (stack.Count != 0 && stack[0] == caps.LastIndexOf(c) - 1)
                stack.RemoveAt(0);
            else
                stack.Insert(0, index);
        }
        return stack.Count == 0;
    }
}
