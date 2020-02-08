using System;
using System.Linq;
public class User
{
    public int[] rank_arr;
    public int pos, rank, progress;

    public User()
    {
        this.rank_arr = new int[] {-8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8};
        this.pos = 0;
        this.rank = this.rank_arr[this.pos];
        this.progress = 0;
    }
    public void incProgress(int n)
    {
        int new_pos = Array.IndexOf(this.rank_arr, n);
        if (new_pos == -1)
            throw new ArgumentException();
        int pos_span = new_pos - this.pos;
        if (pos_span == 0)
            this.progress += 3;
        else if (pos_span == -1)
            this.progress += 1;
        else if (pos_span > 0)
            this.progress += pos_span * pos_span * 10;
        int rank_up = this.progress / 100;
        this.progress -= rank_up * 100;
        this.pos += rank_up;
        this.rank = this.rank_arr[this.pos];
        this.progress = this.rank == 8 ? 0 : this.progress;
    }
}
