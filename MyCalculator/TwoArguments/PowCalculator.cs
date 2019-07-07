using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
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