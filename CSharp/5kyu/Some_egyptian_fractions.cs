using System;
using System.Linq;
using System.Collections.Generic;

public class Decomp 
{

  public static string Decompose(string nrStr, string drStr) 
  {
      long nr = Convert.ToInt64(nrStr);
      long dr = Convert.ToInt64(drStr);
      
      if (nr == 0 || dr == 0)
          return "[]";
      if (nr == dr)
          return "[1]";
      string res = "[";
      while (nr != 0 && dr != 0)
      {
          if (nr > dr)
          {
              res += nr / dr;
              nr -= nr / dr * dr;
          }
          else
          {
              res += "1/";
              long q;
              if (dr % nr == 0)
                  q = dr / nr;
              else
                  q = dr / nr + 1;
              res += q;
              nr = nr * q - dr;
              dr *= q;         
          }
          res += ", ";
      }
      return res.Substring(0, res.Length - 2) + "]";
  }
  
}
