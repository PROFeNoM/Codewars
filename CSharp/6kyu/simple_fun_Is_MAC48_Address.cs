namespace myjinxin
{
    using System.Text.RegularExpressions;
    
    public class Kata
    {
        public bool IsMAC48Address(string InputString){
          return Regex.IsMatch(InputString, @"\A([0-9A-F]{2}[-]{1}){5}([0-9A-F]{2})\z");
          
          
        }
    }
}
