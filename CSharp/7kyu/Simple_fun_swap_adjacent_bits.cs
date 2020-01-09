namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int SwapAdjacentBits(int n){
          int[] binary_repr = Convert.ToString(n, 2).Select(x=> x - 48).ToArray();
          int[] arr_to_swap = new int[32-binary_repr.Length].Concat(binary_repr).ToArray();
          for (int i = 30; i >= 2; i -= 2)
          {
            int temp = arr_to_swap[i+1];
            arr_to_swap[i+1] = arr_to_swap[i];
            arr_to_swap[i] = temp;
          }
          return Convert.ToInt32(string.Join("", arr_to_swap), 2);
          
          
          
        }
    }
}
