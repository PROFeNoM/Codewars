namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int RunnersMeetings(int[] StartPosition, int[] speed)
        {
          int output = 1, d, s, cnt, time;
          for (int i = 0; i < StartPosition.Length; i++)
          {
            for (int j = i + 1; j < StartPosition.Length; j++)
            {
              d = Math.Abs(StartPosition[j] - StartPosition[i]);
              s = Math.Abs(speed[i] - speed[j]);
              if (s <= 0 && d != 0)
                continue;
              time = StartPosition[i] * s + speed[i] * d;
              cnt = 0;
              for (int k = 0; k < StartPosition.Length; k++)
              {
                if (StartPosition[k] * s + speed[k] * d == time)
                  cnt++;
              }
              if (cnt == 0)
                  continue;
              if (cnt > output)
                output = cnt;
            }
          }
          return output < 2 ? -1 : output;
        }
    }
}
