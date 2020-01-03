namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    
    public class Kata
    {
        public string ReverseLetter(string str){
          Regex rgx = new Regex("[^a-z]");
          return String.Concat(rgx.Replace(str, "").Reverse());
        }
    }
}
