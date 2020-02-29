using System;
using System.Linq;
using System.Collections.Generic;
public class InterlacedSpiralCipher
{
    public static string Encode(string s)
    {
/*         Square Initialization */
        int iq = (int)Math.Round(Math.Sqrt(s.Length));
        int square_size = iq * iq >= s.Length ? iq : iq + 1;
        char[][] square = new char[square_size][];
        for (int i = 0; i < square_size; i++)
            square[i] = new char[square_size];
        
/*         Encoding Sequence Generation */
        List<int[]> position = new List<int[]>();
        for (int i = 0; i <= square_size / 2; i++)
            position = position.Concat(ESG(i, square_size)).ToList();
        
/*         Encryption Process */
        for (int j = 0; j < s.Length; j++)
            square[position[j][0]][position[j][1]] = s[j];
        
        return String.Join("", square.SelectMany(e => e)).Replace("\0", " ");
        
    }
    
    public static string Decode(string s)
    {
/*         Square Initialization */
        int iq = (int)Math.Round(Math.Sqrt(s.Length));
        int square_size = iq * iq >= s.Length ? iq : iq + 1;
        string res = "";
        
/*         Decoding Sequence Generation */
        List<int> position = new List<int>();
        for (int i = 0; i <= square_size / 2; i++)
            position = position.Concat(ESG(i, square_size).Select(e => e[1] + e[0] * square_size)).ToList();
            
/*         Decryption Process */
        foreach (int i in position.Take(square_size*square_size))
            res += s[i];
        return res.Trim();
    }
    
    public static List<int[]> ESG(int i, int sz)
    {
        if (i == sz / 2)
        {
            return new List<int[]> { new int[] { i, i } };
        }    
        else
        {
            List<int[]> first_seq = Enumerable.Range(0, sz - 1 - i).Select(e => new int[] { i, i + e }).ToList();
            List<int[]> second_seq = Enumerable.Range(0, sz - 1 - i).Select(e => new int[] { i + e, sz - 1 - i}).ToList();
            List<int[]> third_seq = Enumerable.Range(0, sz - 1 - i).Select(e => new int[] { sz - 1 - i, sz - 1 - i - e}).ToList();
            List<int[]> fourth_seq = Enumerable.Range(0, sz - 1 - i).Select(e => new int[] { sz - 1 - i - e, i}).ToList();
            
            List<int[]> res = new List<int[]>();
            for (int j = 0; j < sz - 1 - 2 * i; j++)
            {
                res.Add(first_seq[j]);
                res.Add(second_seq[j]);
                res.Add(third_seq[j]);
                res.Add(fourth_seq[j]);
            }
            return res;
        }
    }
}
