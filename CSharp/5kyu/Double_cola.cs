using System;

public class Line
    {
        public static string WhoIsNext(string[] names , long n)
        { 
              while (n > 5)
                    n = (n - 4) / 2;
              return names[n - 1];
        }
    }
