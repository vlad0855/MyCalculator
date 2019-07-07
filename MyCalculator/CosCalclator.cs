using MyCalculator.OneArgument;
using System;

namespace MyCalculator
{
    public class CosCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Cos(firstValue);
            return result;
        }
    }
}