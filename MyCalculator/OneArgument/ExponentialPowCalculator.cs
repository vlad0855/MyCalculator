using System;
using MyCalculator.OneArgument;

namespace MyCalculator
{
    public class ExponentialPowCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// Exponential X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Exp(firstValue);
            return result;
        }
    }
}