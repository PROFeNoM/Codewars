using System;

public class ToSmallest 
{
    public static long[] Smallest (long n)
    {
        string num = n.ToString();
        long[] result = null;

        for (int i = 0; i < num.Length; i++)
            for (int j = 0; j < num.Length; j++)
            {
                long[] t = Move(num, i, j);

                result = Max(result, t);
            }

        return result;
    }

    private static long[] Move(string num, int i, int j)
    {
        string c = num[i].ToString();
        num = num.Remove(i, 1);
        num = num.Insert(j, c);

        return new long[] { long.Parse(num), i, j };
    }

    private static long[] Max(long[] a, long[] b)
    {
        if (a == null)
            return b;

        if (b == null)
            return a;

        for(int i=0; i<3; i++)
        {
            if (a[i] < b[i])
                return a;
            
            if (b[i] < a[i])
                return b;
        }

        return a;
    }
}
