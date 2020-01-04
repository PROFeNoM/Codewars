namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public string[] NewNumeralSystem(char number){
          int idx = number - 65;
          return Enumerable.Range(0, idx / 2 + 1).Select(i => $"{(char)(65 + i)} + {(char)(idx + 65 - i)}").ToArray();
          
          
          
        }
    }
}
