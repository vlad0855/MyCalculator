using System;

namespace MyCalculator.OneArgument
{
    public class SinCalculator : IOneArgumentCalculator
    {
        /// <summary>
        ///  Sin X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Sin(firstValue);
            return result;
        }
    }
}