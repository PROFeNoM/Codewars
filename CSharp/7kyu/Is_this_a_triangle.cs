using System;

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        int[] arr = new int[] { a, b, c };
        Array.Sort(arr);
        return ((arr[0] + arr[1]) > arr[2]);
    }
}
