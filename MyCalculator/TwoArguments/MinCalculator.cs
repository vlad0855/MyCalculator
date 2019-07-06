using System;

namespace MyCalculator.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}