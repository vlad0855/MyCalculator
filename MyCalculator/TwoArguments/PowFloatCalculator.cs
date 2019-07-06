using System;

namespace MyCalculator.TwoArguments
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