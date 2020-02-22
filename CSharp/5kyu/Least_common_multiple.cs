using System;
using System.Collections.Generic;

public static class Kata
{
  public static int Lcm(List<int> nums)
  {
    while (nums.Count > 1)
    {
        nums[1] = twoLcm(nums[0], nums[1]);
        nums.RemoveAt(0);
    }
    return nums.Count == 0 ? 1 : nums[0];
  }
  
  public static int twoLcm(int a, int b) => a * (b / gcd(a, b));
  
  public static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b);
}
