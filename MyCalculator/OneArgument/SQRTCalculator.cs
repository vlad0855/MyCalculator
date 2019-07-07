using System;

namespace MyCalculator.OneArgument
{
    public class SqrtCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Sqrt(firstValue);
            return result;
        }
    }
}
