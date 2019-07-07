using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class ModCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}