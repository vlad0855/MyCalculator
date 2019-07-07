using MyCalculator.OneArgument;
using System;

namespace MyCalculator
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = 1.0 / Math.Tan(firstValue);
            return result;
        }
    }
}