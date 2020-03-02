using System;

class EulerOde {
    
    public static double ExEuler(int nb) {
        double y = 1;
        double t = 0;
        double error = Math.Abs(y - ExactSol(t))/ExactSol(t);
        for (int i = 0; i < nb; i++)
        {
            y += Slope(y, t) * ((double)1/nb);
            t += (double)1/nb;
            error += Math.Abs(y - ExactSol(t))/ExactSol(t);
        }
        return (int)(error / (nb + 1) * 1000000)/(double)1000000;
    }
    
    public static double ExactSol(double t) {
        return 1 + 0.5 * Math.Exp(-4 * t) - 0.5 * Math.Exp(-2 * t);
    }
    
    public static double Slope(double y, double t) {
        return 2 - Math.Exp(-4 * t) - 2 * y;
    }
}
