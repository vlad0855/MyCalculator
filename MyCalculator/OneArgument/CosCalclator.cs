using System;

namespace MyCalculator.OneArgument
{
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Cos X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Cos(firstValue);
            return result;
        }
    }
}