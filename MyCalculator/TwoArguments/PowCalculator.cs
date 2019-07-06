using System;

namespace MyCalculator.TwoArguments
{
    public class PowCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            return result;
        }
    }
}