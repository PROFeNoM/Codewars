using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
    int count = 0;
		while (n >= 10)
    {
      count++;
      string num_litteral = Convert.ToString(n);
      char[] char_arr = num_litteral.ToCharArray();
      int next_n = 1;
      foreach (char num_ch in char_arr)
      {
        int num = (int)Char.GetNumericValue(num_ch);
        Console.WriteLine("-->"+num);
        next_n *= num;
      }
      n = next_n;
    }
    return count;
	}
}
