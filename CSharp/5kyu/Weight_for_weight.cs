using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WeightSort {
	
	public static string orderWeight(string strng) {
		return String.Join(" ", Regex.Split(strng.Trim(), @"\s+").OrderBy(w => w.Sum(d => d -'0')).ThenBy(w => w));
	}
}
