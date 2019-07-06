using System;

namespace MyCalculator.TwoArguments
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}