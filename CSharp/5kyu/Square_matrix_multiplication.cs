using System;
public class Kata
{
    public static int[,] MatrixMultiplication(int[,] a, int[,] b)
    {
        int n = a.GetLength(0);
        int [,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    matrix[i, j] += a[i, k] * b[k, j];
        return matrix;
    }
}
