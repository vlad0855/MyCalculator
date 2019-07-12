using System;

namespace MyCalculator.OneArgument
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Ctan X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = 1.0 / Math.Tan(firstValue);
            return result;
        }
    }
}