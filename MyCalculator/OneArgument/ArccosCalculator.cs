using MyCalculator.OneArgument;
using System;

namespace MyCalculator
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Acos(firstValue);
            return result;
        }
    }
}