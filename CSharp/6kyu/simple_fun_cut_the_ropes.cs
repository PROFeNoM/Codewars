namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Kata
    {
        public int[] CutTheRopes(int[] a){
          List<int> res = new List<int>() { a.Length };
          Array.Sort(a);
          while (true)
          {
            a = a.Select(x => x - a[0]).Where(x => x > 0).ToArray();
            if (a.Count() > 0)
              res.Add(a.Length);
            else
              return res.ToArray();
          }
          
          
        }
    }
}
