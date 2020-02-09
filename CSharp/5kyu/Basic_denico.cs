using System;
using System.Linq;
public class Kata {
  public static string DeNico(string key, string m) {
      int [] coder = key.OrderBy(x=>x).Select(e=> key.IndexOf(e)).ToArray();
      return string.Concat(m.Select((e,i)=>m[ (i / key.Length)*key.Length + Array.IndexOf(coder,i%key.Length) ])).TrimEnd(' ');
  }
}
