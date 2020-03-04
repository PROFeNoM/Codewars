using System;
public class TheClockwiseSpiral
{
    public static int[,] CreateSpiral(int N)
    {
        int[,] res = new int [N, N];
        int e =1;
        int i=0, j = 0, k = 0, n = N;
        for(;n>0;n-=2){
            for(i=0;i<n;i++){
                res[j, j+i]=e;
                e++;
                         
            }
            for(k=1;k<n;k++){
                res[j+k, N-j-1]=e;
                e++;
            }
            for(i=1;i<n;i++){
                res[j+k-1, N-1-j-i]=e;
                e++;
            }
            for(k=1;k<n-1;k++){
                res[N-1-j-k, j]=e;
                e++;
            }
   
            j++;
        }
         
        return res;
    }
}
