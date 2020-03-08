using System;

public class Packer
{
    public static int PackBagpack(int[] scores, int[] weights, int capacity)
    {
        int n = scores.Length;
        int[,] matrix = new int[n + 1, capacity + 1];
        for (int row = 0; row <= capacity; row++)
            matrix[0, row] = 0;
        for (int col = 0; col <= n; col++)
            matrix[col, 0] = 0;
        for (int i = 1; i <= n; i++)
            for (int j = 1; j <= capacity; j++)
            {
                int max = matrix[i - 1, j], curr_max = 0, curr_weight = weights[i - 1];
                if (j >= curr_weight)
                {
                    curr_max = scores[i - 1];
                    int capacity_left = j - curr_weight;
                    curr_max += matrix[i - 1, capacity_left];
                }
                matrix[i, j] = Math.Max(max, curr_max);
            }
        return matrix[n, capacity];
    }
}
