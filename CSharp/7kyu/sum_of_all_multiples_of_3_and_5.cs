using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
      return Enumerable.Range(1, n).Where(num => num % 3 == 0 || num % 5 == 0).Sum();
    }
  }
}
