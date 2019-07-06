using System;

namespace MyCalculator.OneArgument
{
    public class PowTwoCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(2,firstValue);
            return result;
        }
    }
}