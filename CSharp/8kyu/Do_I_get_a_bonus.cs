using System;

public static class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
            return "$" + Convert.ToString(salary * (1 + 9 * Convert.ToInt32(bonus)));
        }
    }
