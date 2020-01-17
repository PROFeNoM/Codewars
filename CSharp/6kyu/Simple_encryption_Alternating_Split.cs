using System;
using System.Linq;

public class Kata
{
  public static string Encrypt(string text, int n)
  {
    if (String.IsNullOrEmpty(text))
      return text;
    string res = text;
    for (int k = 0; k < n; k++)
    {
      string a = String.Join("", res.Select((x, i) => (x, i)).Where(x => x.Item2 % 2 == 1).Select(x => x.Item1).ToArray());
      string b = String.Join("", res.Select((x, i) => (x, i)).Where(x => x.Item2 % 2 == 0).Select(x => x.Item1).ToArray());
      res = String.Concat(a, b);
    }
    return res;
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
    if (String.IsNullOrEmpty(encryptedText))
      return encryptedText;
    string res = encryptedText;
    int len = res.Length / 2;
    for (int k = 0; k < n; k++)
    {
      string a = res.Substring(0, len);
      string b = res.Substring(len);
      res = String.Join("", b.Zip(a, (i, j) => "" + i + j)) + 
                      (b.Length > a.Length ? b[b.Length - 1] + "" : 
                      (a.Length > b.Length ? a[a.Length - 1] + "" : ""));
    }
    return res;
  }
}
