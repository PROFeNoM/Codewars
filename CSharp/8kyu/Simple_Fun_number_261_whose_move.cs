public class Kata
{
  public static string WhoseMove(string lastPlayer, bool win)
  {
    return win ? lastPlayer : (lastPlayer == "black" ? "white" : "black");
  }
}
