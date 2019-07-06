using System;

namespace MyCalculator.OneArgument
{
    public class SinCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Sin(firstValue);
            return result;
        }
    }
}