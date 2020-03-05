namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int RectangleRotation(int a, int b){
            double Ax = (a + b) / (2 * Math.Sqrt(2));
            double x1 = (a - b) / (2 * Math.Sqrt(2));
            double x2 = (b - a) / (2 * Math.Sqrt(2));
            int cnt = 0;
            int axis_0;

/*             Count the numbers of point on [0, Ax] */
            if (a >= b)
            {
/*                 Keep count from axis x = 0 */
                axis_0 = IntBetween(f(0, b), g(0, b));
                for (int x = 1; x <= Ax; x++)
                {
                    if (x <= x1)
                        cnt += IntBetween(f(x, b), g(x, b));
                    else
                        cnt += IntBetween(h(x, a), g(x, b));
                }
            }
            else
            {
/*                 Keep count from axis x = 0 */
                axis_0 = IntBetween(h(0, a), p(0, a));
                for (int x = 1; x <= Ax; x++)
                {
                    if (x <= x2)
                        cnt += IntBetween(h(x, a), p(x, a));
                    else
                        cnt += IntBetween(h(x, a), g(x, b));
                }
            }
/*             Double up the count by symmetry and then add count from axis x=0*/
            return 2 * cnt + axis_0;
            
          
        }
        
        public double f(int x, int b) => x + 1 / Math.Sqrt(2) * b;
        public double g(int x, int b) => x - 1 / Math.Sqrt(2) * b;
        public double h(int x, int a) => - x + 1 / Math.Sqrt(2) * a;
        public double p(int x, int a) => - x - 1 / Math.Sqrt(2) * a;
        
        public int IntBetween(double yd, double xd) // We assume xd <= yd
        {
            double x = Math.Floor(xd), y = Math.Floor(yd);
            if (y - x == 0)
                return (int)0;
            else if (yd == y)
                return (int)(y - x - 1);
            else
                return (int)(y - x);
        }
    }
}
