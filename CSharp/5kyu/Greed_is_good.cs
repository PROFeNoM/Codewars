using System;

public static class Kata
{
  public static int Score(int[] dice) {
  int score = 0;
  int[] counts = new int[] {0, 0, 0, 0, 0, 0, 0};
  foreach (int x in dice)
    counts[x]++;
  score += counts[1] < 3 ? counts[1] * 100 : 1000 + 100 * (counts[1] - 3);
  score += counts[2] >= 3 ? 200 : 0;
  score += counts[3] >= 3 ? 300 : 0;
  score += counts[4] >= 3 ? 400 : 0;
  score += counts[5] < 3 ? counts[5] * 50 : 500 + 50 * (counts[5] - 3);
  score += counts[6] >= 3 ? 600 : 0;
  return score;
  }
}
