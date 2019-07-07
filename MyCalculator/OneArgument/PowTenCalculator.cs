using System;
using MyCalculator.OneArgument;

namespace MyCalculator
{
    public class PowTenCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(10, firstValue);
            return result;
        }
    }
}