public class Deadfish
{
  public static int[] Parse(string data)
  {
  
    int number_of_outputs = 0;
    foreach (char i in data)
    {
      if (i == 'o')
      {
        number_of_outputs++;
      }
    }
    
    int[] result_arr = new int[number_of_outputs];
    int index = 0;
    int result_int = 0;
    foreach (char i in data)
    {
      switch (i)
      {
        case 'i':
          result_int++;
          break;
        case 'd':
          result_int--;
          break;
        case 's':
          result_int = result_int * result_int;
          break;
        case 'o':
          result_arr[index] = result_int;
          index++;
          break;
      }
    }
    
    return result_arr;
  }
}
