namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int[] ArrayPreviousLess(int[] arr)
        {
          int[] first = new int [] { -1 };
          return first.Concat(Enumerable.Range(1, arr.Length - 1).Select(i => Search(arr.Take(i).ToArray(), arr[i]))).ToArray();
        }
        
        public int Search(int[] arr, int lim)
        {
          for (int i = arr.Length - 1; i >= 0; i--)
          {
            int found = arr[i];
            if (found < lim)
              return found;
          }
          return -1;
        }
    }
}
