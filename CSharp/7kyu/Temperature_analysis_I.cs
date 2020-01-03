using System;
using System.Linq;

public class Kata
{
  public static int? LowestTemperature(string t)
    => t == "" ? null : (int?)(Array.ConvertAll(t.Split(" "), int.Parse)).Min();
}
