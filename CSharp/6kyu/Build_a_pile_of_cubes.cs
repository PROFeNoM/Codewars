using System;
public class ASum {
	
	public static long findNb(long m, int t = 0, int n = 0) {
		return m > 0 ? findNb(m - (long)Math.Pow(n + 1, 3), t + 1, n + 1) : m < 0 ? -1 : t;
	}
	
}
