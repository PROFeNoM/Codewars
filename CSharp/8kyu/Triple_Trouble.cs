public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
    string result = "";
    for (int i = 0; i < one.Length; i++)
      result += "" + one[i] + two[i] + three[i];
    return result;
  }
}
