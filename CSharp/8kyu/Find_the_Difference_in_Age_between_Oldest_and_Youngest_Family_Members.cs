using System.Linq;

public class Kata
{
  public static int[] DifferenceInAges(int[] ages)
  {
    return new int[] { ages.Min(), ages.Max(), ages.Max() - ages.Min() };
  }
}
