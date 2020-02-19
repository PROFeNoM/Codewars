using System;
public class JosephusSurvivor 
{
  	public static int JosSurvivor(int n, int k) 
    {
    	int v = 0;
      for (int i = 1; i < n + 1; i++)
        v = (v + k) % i;
      return v + 1;
    }  
}
