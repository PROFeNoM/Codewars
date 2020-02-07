using System;
using System.Linq;
using System.Collections.Generic;
public class RailFenceCipher
{
   public static string Encode(string s, int n)
   {
       List<List<char>> fence = new List<List<char>>();
       for (int i = 0; i < n; i++)
           fence.Add(new List<char>());
       int rail = 0;
       int dist = 1;
       
       foreach (char c in s)
       {
           fence[rail].Add(c);
           rail += dist;
           if (rail == n - 1 || rail == 0)
               dist = - dist;
       }
       string res = "";
       foreach(var r in fence)
           res += String.Join("", r);
       return res;
   }

   public static string Decode(string s, int n)
   {
       List<List<char>> fence = new List<List<char>>();
       for (int k = 0; k < n; k++)
           fence.Add(new List<char>());
       int rail = 0;
       int dist = 1;
       
       foreach (char c in s)
       {
           fence[rail].Add(c);
           rail += dist;
           if (rail == n - 1 || rail == 0)
               dist = - dist;
       }
       
       List<List<char>> resFence = new List<List<char>>();
       for (int k = 0; k < n; k++)
           resFence.Add(new List<char>());
           
       int i = 0;
       int len = s.Length;
       foreach (var r in fence)
       {
           for (int j = 0; j < r.Count(); j++)
           {
               resFence[i].Add(s[0]);
               s = s.Substring(1);
           }
           i += 1;
       }
       
       rail = 0;
       dist = 1;
       string res = "";
       for (int k = 0; k < len; k++)
       {
           res += resFence[rail][0];
           resFence[rail].RemoveAt(0);
           rail += dist;
           if (rail == n - 1 || rail == 0)
               dist = - dist;
       }
       return res;
   }
}
