using System;
using MyCalculator.OneArgument;

namespace MyCalculator
{
    public class SinCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Sin(firstValue);
            return result;
        }
    }
}