using System;

public class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {
        for (int row = pyramid.Length - 2; row >= 0; row--)
          for (int col = 0; col < pyramid[row].Length; col++)
            pyramid[row][col] += Math.Max(pyramid[row + 1][col], pyramid[row + 1][col + 1]);
        return pyramid[0][0];
    }
}
