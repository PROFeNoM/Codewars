using System.Linq;

public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    int i = 1;
    return new int[m].Select(x => n*i++).ToArray();
  }
}
