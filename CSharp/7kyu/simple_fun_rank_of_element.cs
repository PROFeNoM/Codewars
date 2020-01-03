namespace myjinxin
{
    using System.Linq;
    
    public class Kata
    {
        public int RankOfElement(int[] arr, int i){
          return arr.Take(i).Where(x => x <= arr[i]).Count() + arr.Skip(i+1).Where(x => x < arr[i]).Count();
        }
    }
}
