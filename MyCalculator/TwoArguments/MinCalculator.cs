using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}