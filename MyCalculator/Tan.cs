using MyCalculator.OneArgument;
using System;

namespace MyCalculator
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Tan(firstValue);
            return result;
        }
    }
}