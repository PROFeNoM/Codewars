using System;

public class Kata
{
  public static int count = 0;
  
  public static Func<char> MakeLooper(string str)
  {
    return new Func<char>( () => {
      char res = str[count++];
      count %= str.Length;
      return res;
    });
  }
}
