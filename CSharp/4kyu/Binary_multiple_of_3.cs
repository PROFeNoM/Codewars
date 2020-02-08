using System;
using System.Text.RegularExpressions;

public class BinaryRegex {

  public static Regex MultipleOf3() {
    // Regular expression that matches binary inputs that are multiple of 3
    return new Regex("^(0*(1(01*0)*1)*)*$");
  }
}
