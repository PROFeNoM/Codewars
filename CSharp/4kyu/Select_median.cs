using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public interface IWarrior {
  // a.IsBetter(b) returns true if and only if
  // warrior a is no worse than warrior b, i.e. a>=b
  bool IsBetter(IWarrior other);
}

public static class Kata {
  // warriors is IWarrior[5]
  public static IWarrior SelectMedian(IWarrior[] warriors){
      IWarrior a = warriors[0], b = warriors[1], c = warriors[2], d = warriors[3], e = warriors[4];
      IWarrior temp;
      if ( b.IsBetter(a) )
      {
          temp = b;
          b = a;
          a = temp;
      }
      if ( d.IsBetter(c) )
      {
          temp = d;
          d = c;
          c = temp;
      }
      if ( c.IsBetter(a) )
      {
          temp = a;
          a = c;
          c = temp;
          
          temp = b;
          b = d;
          d = temp;
      }
      if ( e.IsBetter(b) )
      {
          temp = e;
          e = b;
          b = temp;
      }
      if ( b.IsBetter(c) )
      {
          if ( c.IsBetter(e) )
              return c;
          else
              return e;
      }
      else
      {
          if ( b.IsBetter(d) )
              return b;
          else
              return d;
      }
    
    }
}
