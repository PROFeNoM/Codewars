using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static string Rot13(string message)
  {
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    string rot = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
    Dictionary<char, char> process = new Dictionary<char, char>();
    for (int i = 0; i < rot.Length; i++)
      process.Add(alphabet[i], rot[i]);
    return String.Join("", message.Select(e => process.ContainsKey(e) ? process[e] : e));
  }
}
