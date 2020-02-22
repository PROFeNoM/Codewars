public class Suite
{
	public static double going(int n) 
	{
		double res = 1;
    double acc = 1;
    for (int i = n; i > 1; i--)
    {
        acc /= i;
        res += acc;
    }
    return res;
	}
}
