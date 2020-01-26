using System;
using System.Linq;
using System.Text.RegularExpressions;

public class DirReduction {
  
    public static string[] dirReduc(String[] arr) {
        string str = String.Join("1", arr);
        while (Regex.IsMatch(str, "NORTH1+SOUTH|EAST1+WEST|WEST1+EAST|SOUTH1+NORTH"))
            str = Regex.Replace(str, "NORTH1+SOUTH|EAST1+WEST|WEST1+EAST|SOUTH1+NORTH", "");
        return str.Split("1").Where(s => Regex.IsMatch(s, "[A-Z]+")).ToArray();
    }
}
