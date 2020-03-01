using System;
using System.Linq;
using System.Collections.Generic;

public class IterativeRotationCipher
{
	  public static string Encode(int n, string s)
	  {
        for(int t = 0; t < n; t++)
        {
/*             Step 1: remove all spaces in the string (but remember their positions) */
            List<int> spaces_indexes = SpacesIndexes(s);
            s = s.Replace(" ", "");

/*             Step 2: shift the order of characters in the new string to the right by n characters */
            s = ShiftRight(s, n);
            
/*             Step 3: put the spaces back in their original positions */
            foreach (int i in spaces_indexes)
                s = s.Insert(i, " ");
            
/*             Step 4: shift the characters of each substring (separated by one or more consecutive spaces) to the right by n */
            s = String.Join(" ", s.Split(' ').Select(e => ShiftRight(e, n)));
            
        }
        return String.Format("{0} {1}", n, s);

	  }

    public static string Decode(string s)
	  {
        int n = Convert.ToInt32( s.Substring(0, s.IndexOf(" ")) );
        s = s.Substring(s.IndexOf(" ") + 1);

        for(int t = 0; t < n; t++)
        {
/*             Step 1: shift the characters of each substring (separated by one or more consecutive spaces) to the LEFT by n */
            s = String.Join(" ", s.Split(' ').Select(e => ShiftLeft(e, n)));
            
/*             Step 2: remove all spaces in the string (but remember their positions) */
            List<int> spaces_indexes = SpacesIndexes(s);
            s = s.Replace(" ", "");
            
/*             Step 3: shift the order of characters in the new string to the left by n characters */
            s = ShiftLeft(s, n);
            
/*             Step 4: put the spaces back in their original positions */
            foreach (int i in spaces_indexes)
                s = s.Insert(i, " ");

        }
        return s;
	  }

    public static string ShiftLeft(string s, int n)
    {
        if (s.Length == 0)
            return s;
        n %= s.Length;
        return s.Substring(n) + s.Substring(0, n);
    }
    
    public static string ShiftRight(string s, int n)
    {
        if (s.Length == 0)
            return s;
        n %= s.Length;
        return s.Substring(s.Length - n) + s.Substring(0, s.Length - n);
    }
    
    public static List<int> SpacesIndexes(string s)
    {
        List<int> spaces_indexes = new List<int>();
        for (int i = s.IndexOf(" "); i > -1; i = s.IndexOf(" ", i + 1))
            spaces_indexes.Add(i);
        return spaces_indexes;

    }
}
