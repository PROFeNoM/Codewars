using System;
using System.Linq;
using System.Reflection;

public static class Reflection
{
  public static string[] GetMethodNames(object TestObject)
  { 
    if (TestObject == null)
        return new string[0];
    return TestObject.GetType().GetMethods(
    BindingFlags.Static |
    BindingFlags.NonPublic |
    BindingFlags.Public |
    BindingFlags.Instance
    ).Select(e => e.Name).ToArray();
  }
}
