using System;

namespace MyCalculator.OneArgument
{
    public class CosCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Cos(firstValue);
            return result;
        }
    }
}