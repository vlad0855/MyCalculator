using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}