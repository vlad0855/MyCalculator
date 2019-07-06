using System;

namespace MyCalculator.OneArgument
{
    public class AbsCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Abs(firstValue);
            return result;
        }
    }
}