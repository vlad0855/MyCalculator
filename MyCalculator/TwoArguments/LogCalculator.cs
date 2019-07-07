using System;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class LogCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Log(secondValue,firstValue);
            return result;
        }
    }
}