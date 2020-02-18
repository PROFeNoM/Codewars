using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i < Math.Log(n) / Math.Log(2) + 1; i++)
            for (int j = 2; Math.Pow(j, i) <= n; j++)
                if (Math.Pow(j, i) == n)
                    return (j, i);
        return null;
    }
}
