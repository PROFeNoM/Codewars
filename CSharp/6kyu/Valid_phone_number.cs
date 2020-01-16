using System.Text.RegularExpressions;

public static class Kata
{
  public static bool ValidPhoneNumber(string phoneNumber)
  {
    return Regex.IsMatch(phoneNumber, "\\A\\(\\d{3}\\)\\s\\d{3}\\-\\d{4}\\z");
  }
}
