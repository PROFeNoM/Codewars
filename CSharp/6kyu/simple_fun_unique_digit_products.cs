namespace myjinxin
{
    using System.Linq;
    public class Kata
    {
        public int UniqueDigitProducts(int[] a){
          return a.Select(n => n.ToString().Select(x => x - 48).Aggregate(1, (y, z) => y * z)).Distinct().Count();
          
          
        }
    }
}
