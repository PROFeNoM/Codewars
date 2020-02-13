using System;

public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    int res = 0;
    for (int i = 0, temp = 0; i < arr.Length; i++)
    {
      temp += arr[i];
      temp = Math.Max(temp, 0);
      res = Math.Max(res, temp);
    }
    return res;
  }
}
