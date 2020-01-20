using System;
using System.Linq;

public class Kata
{
  public static string ThueMorse(int n) 
  {
    string seq = "0";
    while (seq.Length < n)
      seq += String.Join("", seq.Select(e => e == '1' ? '0' : '1').ToArray());
    return seq.Substring(0, n);
  }
}
