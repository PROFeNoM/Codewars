using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int BowlingScore(string frames)
    {
        string pattern = "X|[0-9]/";
        Regex rgx = new Regex(pattern);
        string[] frames_arr = frames.Split(" ");
        int score = 0;
        for (int i = 0; i < frames_arr.Length; i++)
        {
          if (rgx.IsMatch(frames_arr[i]))
          {
            if (i < 9)
            {
              frames_arr[i] = string.Join("", frames_arr.Skip(i).Take(frames_arr.Length)).Substring(0, 3);
            }
          }
          char[] score_element = rgx.Replace(frames_arr[i], "X").ToCharArray();
          foreach (char element in score_element)
          {
            Console.Write(element);
            if (element == 'X')
              score += 10;
            else
              score += Convert.ToInt32(element.ToString());
          }
        }
        return score;
    }
}
