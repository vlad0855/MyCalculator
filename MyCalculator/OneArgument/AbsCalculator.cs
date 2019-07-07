using System;
namespace MyCalculator
{
    public class AbsCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Abs(firstValue);
            return result;
        }
    }
}