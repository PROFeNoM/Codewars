using System;
using System.Linq;

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int FaultyOdometer(int n){
            return Convert.ToString(n).ToCharArray().Reverse().Select( (e, i) => "012356789".IndexOf(e) * (int)Math.Pow(9, i) ).Sum();
          
          
        }
    }
}
