using System;

namespace MyCalculator.OneArgument
{
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Tan X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Tan(firstValue);
            return result;
        }
    }
}