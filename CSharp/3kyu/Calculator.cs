using System;
using System.Data;
public class Evaluator
{
    public double Evaluate(string expression)
    {
        string res = Convert.ToString(Convert.ToDouble(new DataTable().Compute(expression, null)));
        return Convert.ToDouble(res.Substring(0,res.Length > 13 ? 13 : res.Length));
    }
}
