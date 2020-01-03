namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int ArrayPacking(int[] a){
          return Convert.ToInt32(string.Join("", a.Reverse().Select(x => Convert.ToString(x, 2)).Select(x => new String('0', 8-x.Length) + x)), 2);
        }
    }
}
