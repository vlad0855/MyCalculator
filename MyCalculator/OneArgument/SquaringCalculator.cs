using System;

namespace MyCalculator.OneArgument
{
   public class SquaringCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(firstValue,2);
            return result;
        }
    }
}
