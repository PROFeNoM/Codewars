using System;
using System.Linq;
public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    int[] rgb = new int[] {r, g, b};
    return String.Join("", rgb.Select(e => ("0" + Convert.ToString(inRange(e), 16)).Substring(("0" + Convert.ToString(inRange(e), 16)).Length -2).ToUpper() ));
  }
  
  public static int inRange(int n) 
  {
    return n > 255 ? 255 : (n < 0 ? 0 : n);
  }
}
