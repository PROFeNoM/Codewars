using System;

public class StringMerger
{
	public static bool isMerge(string s, string part1, string part2)
	{
		if (part1 == "")
      return s == part2;
    if (part2 == "")
      return s == part1;
    if (s == "")
      return part1 + part2 == "";
    if (s[0] == part1[0] && isMerge(s.Substring(1), part1.Substring(1), part2))
      return true;
    if (s[0] == part2[0] && isMerge(s.Substring(1), part1, part2.Substring(1)))
      return true;
    else
      return false;
	}
}
