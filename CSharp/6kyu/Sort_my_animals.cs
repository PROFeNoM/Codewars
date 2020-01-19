using System;
using System.Linq;
using System.Collections.Generic;

namespace Kata
{
  public class Animal
  {
    public string Name { get; set; }
    public int NumberOfLegs { get; set; }
  }

  public class AnimalSorter
  {
    public int Compare(Animal x, Animal y)
    {
      if (x.NumberOfLegs < y.NumberOfLegs)
        return -1;
      else if (x.NumberOfLegs > y.NumberOfLegs)
        return 1;
      else
        return x.Name.CompareTo(y.Name);
    } 
    
    public List<Animal> Sort(List<Animal> input)
    {
      if (input == null || input.Count == 0)
        return input;
      input.Sort(Compare);
      return input;
    }
  }
   
}
