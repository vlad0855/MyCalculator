using MyCalculator.OneArgument;
using System;

namespace MyCalculator
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Asin(firstValue);
            return result;
        }
    }
}