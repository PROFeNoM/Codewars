namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int ElectionsWinners(int[] votes, int k){
          int max = votes.Max();
          return k == 0 && votes.Count(num => num == max) == 1 ? 1 : votes.Where(num => num + k > max).Count();
          
        }
    }
}
