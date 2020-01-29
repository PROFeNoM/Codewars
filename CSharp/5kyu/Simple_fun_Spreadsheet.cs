namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    
    public class Kata
    {
        public static string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        public string Spreadsheet(string s){
          if (Regex.IsMatch(s, @"^[A-Z]+\d+$"))
              return "R" + Regex.Match(s, @"\d+").ToString() + "C" + fromBase26(Regex.Match(s, "[A-Z]+").ToString());
          else
              return toBase26(Regex.Matches(s, @"\d+")[1].ToString()) + Regex.Match(s, @"\d+").ToString();
        }
        
        public string toBase26(string n){
            int num = Convert.ToInt32(n);
            string res = "";
            if (num < 26)
                return ALPHABET[num - 1].ToString();
            
            while (num > 0){
                if (num % 26 == 0){
                    res += "Z";
                    num = num / 26 - 1;
                }
                else{
                    res += ALPHABET[(num % 26) - 1].ToString();
                    num = num / 26;
                }
            }
            
            return String.Join("", res.Reverse()); 
        }
        
        public string fromBase26(string s){
            return Convert.ToString( s.Reverse().Select( (n, i) => (ALPHABET.IndexOf(n) + 1) * (int)Math.Pow(26, i) ).Sum() );
        }
    }
}
