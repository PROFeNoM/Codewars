public class NumberTranslation
{
    public static string Number2Words(int n)
    {
        string[] special = new string[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
        string[] regular = new string[] {"twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
        if (n >= 0 && n < 20) return special[n];
        else if (n >= 20 && n < 100) return regular[n / 10 - 2] + (n % 10 == 0 ? "" : "-" + special[n % 10]);
        else if (n >= 100 && n < 1000) return special[n / 100] + " hundred" + (n % 100 == 0 ? "" : " " + Number2Words(n % 100));
        else return Number2Words(n / 1000) + " thousand" + (n % 1000 == 0 ? "" : " " + Number2Words(n % 1000));
    }
}
