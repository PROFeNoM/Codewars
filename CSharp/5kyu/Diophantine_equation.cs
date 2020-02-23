using System;

public class Dioph {
	
	public static string solEquaStr(long n) {
		string res = "[";
    for (int i = 1; i < (int)Math.Sqrt(n) + 1; i++) {
      if (n % i == 0) {
        long j = n / i;
        if ( (i + j) % 2 == 0 && (j - i) % 4 == 0) {
          long x = (i + j) / 2;
          long y = (j - i) / 4;
          if (res.Length > 1)
            res += String.Format(", [{0}, {1}]", x, y);
          else
            res += String.Format("[{0}, {1}]", x, y);
        }
      }
    }
    return res + "]";
	}
}
