public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    return new int[]{ humanYears, humanYears >= 2 ? (24 + (humanYears - 2) * 4) : 15, humanYears >= 2 ? (24 + (humanYears - 2) * 5) : 15 };
  }

}
