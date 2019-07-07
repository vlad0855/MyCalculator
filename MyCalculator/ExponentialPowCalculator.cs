using System;
using MyCalculator.OneArgument;

namespace MyCalculator
{
    public class ExponentialPowCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Exp(firstValue);
            return result;
        }
    }
}