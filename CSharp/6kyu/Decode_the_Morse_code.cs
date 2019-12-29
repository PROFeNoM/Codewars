using System; 
using System.Linq;

class MorseCodeDecoder
{
	public static string Decode(string morseCode)
	{
		morseCode = morseCode.Replace("   ","  ");
    string[] morseCodeArr = morseCode.Split(" ");
    string result = "";
    foreach (string x in morseCodeArr)
    {
      if (x == "")
        result += " ";
      else
        result += MorseCode.Get(x);
    }
    while (result[0] == ' ')
    {
      result = result.Substring(1);
    }
    while (result[result.Length - 1] == ' ')
    {
      result = result.Substring(0, result.Length - 1);
    }
    return result;
	}
}
