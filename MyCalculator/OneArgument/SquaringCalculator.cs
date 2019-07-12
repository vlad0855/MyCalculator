using System;

namespace MyCalculator.OneArgument
{
    public class SquaringCalculator : IOneArgumentCalculator
    {
        /// <summary>
        ///  X power 2
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(firstValue, 2);
            return result;
        }
    }
}
