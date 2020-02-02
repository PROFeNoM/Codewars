using System;
using System.Linq;

public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        return String.Join("\n", text.Split("\n").Select(line => commentSymbols.Select(m => line.TrimEnd().IndexOf(m) == -1 ? 
                                                                                            line.TrimEnd().Length : line.TrimEnd().IndexOf(m)).Min() == -1 ? 
                                                                                                                 line.TrimEnd() : line.TrimEnd().Substring(0, commentSymbols.Select(m => line.TrimEnd().IndexOf(m) == -1 ?
                                                                                                                                                                    line.TrimEnd().Length : line.TrimEnd().IndexOf(m)).Min()).TrimEnd() ) );
    }
}
