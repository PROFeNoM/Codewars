using System.Linq;

public static class Kata
{

  public static bool Disjunction(bool[] operands, bool isExclusive = false)
  {
    
    return operands.Aggregate((x, y) => isExclusive ? x ^ y : x || y);
    
  }
  
}
