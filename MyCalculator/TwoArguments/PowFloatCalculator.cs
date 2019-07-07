using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class PowFloatCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, (1/secondValue));
            return result;
        }
    }
}