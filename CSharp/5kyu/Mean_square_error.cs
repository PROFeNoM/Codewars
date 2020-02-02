using System;

public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
    double sum = 0;
    for (int i = 0; i < firstArray.Length; i++)
      sum += Math.Pow(firstArray[i] - secondArray[i], 2);
    return sum / firstArray.Length;
  }
}
