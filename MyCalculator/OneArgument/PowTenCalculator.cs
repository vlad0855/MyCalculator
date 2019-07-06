using System;

namespace MyCalculator.OneArgument
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