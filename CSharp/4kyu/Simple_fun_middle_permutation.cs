namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public string MiddlePermutation(string s)
        {
            if (s == "") return "";
            int n = s.Length;
            s = String.Concat(s.OrderBy(c => c));
            if (n % 2 == 0) return Middle(s);
            else
            {
                int mid = (n - 1) / 2;
                return s[mid] + Middle(s.Substring(0, mid) + s.Substring(mid + 1));
            }
        }
        
        public string Middle(string s)
        {
            int mid = s.Length / 2 - 1;
            string str = s.Substring(0, mid) + s.Substring(mid + 1);
            return s[mid] + String.Join("", str.Reverse());
        }
    }
}
