using System;
using System.Linq;
using System.Collections.Generic;

public class CaesarCipher
{
  public static List<string> movingShift(string s, int shift)
  {
    string encoded = code(s, shift, 1);
    int cut = encoded.Length / 5 + 1;
    return Enumerable.Range(0, 5 * cut).Where(x => x % cut == 0).Select(i => i + cut < encoded.Length - 1 ? encoded.Substring(i, cut) : encoded.Substring(i)).ToList();
  }

  public static string demovingShift(List<string> s, int shift)
  {
    return code(String.Join("", s), -shift, -1);
  }
  
  public static string code(string str, int shift, int mode)
  {
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string ABC = abc.ToUpper();
    return String.Join("", str.Select((c, i) => abc.Contains(c) ? abc[(abc.IndexOf(c) + i*mode + shift) % 26 >= 0 ? (abc.IndexOf(c) + i*mode + shift) % 26 : 26 + (abc.IndexOf(c) + i*mode + shift) % 26] :
                                                ABC.Contains(c) ? ABC[(ABC.IndexOf(c) + i*mode + shift) % 26 >= 0 ? (ABC.IndexOf(c) + i*mode + shift) % 26 : 26 + (ABC.IndexOf(c) + i*mode + shift) % 26] : c));
  }
}
