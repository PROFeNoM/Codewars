using System;
using System.Linq;
using System.Collections.Generic;

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int SumGroups(int[] arr){
          if (arr.Length == 1)
            return 1;
          List<int> res = arr.ToList();
          List<int> grouped = new List<int>();
          List<int> last_res = new List<int>();
          while (!(res.SequenceEqual(last_res)))
          {
            last_res = res.ToList();
            res.Clear();
            grouped.Add(last_res[0]);
            for (int i = 1; i < last_res.Count(); i++)
            {
              if (last_res[i-1] % 2 == last_res[i] % 2)
                grouped.Add(last_res[i]);
              else
              {
                res.Add(grouped.Sum());
                grouped.Clear();
                grouped.Add(last_res[i]);
              }
            }
            res.Add(grouped.Sum());
            grouped.Clear();
            if (res.Count() == 1)
              return 1;
          } 
          return res.Count();
          
        }
    }
}
