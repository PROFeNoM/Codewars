namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public double Similarity(int[] a, int[] b){
          return (double)a.Where(num => b.Contains(num)).Distinct().Count() / a.Concat(b).Distinct().Count();
          
          
        }
    }
}
