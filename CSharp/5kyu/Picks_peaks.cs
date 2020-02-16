using System;
using System.Collections.Generic;
public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] arr)
    {
        Dictionary<string, List<int>> res = new Dictionary<string, List<int>>(){
                                                                                 { "pos", new List<int>() },
                                                                                 { "peaks", new List<int>() }
                                                                               };
        int key = 0;
        int count = 0;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1])
                key += 1;
            if (arr[i] > arr[i + 1])
                key += 1;
            if (arr[i] == arr[i + 1])
            {
                count += 1;
                continue;
            }
            if (key == 2)
            {
                res["pos"].Add(i - count);
                res["peaks"].Add(arr[i]);
            }
            key = 0;
            count = 0;
        }
        return res;
    }
}
