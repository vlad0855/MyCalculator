using System;

namespace MyCalculator.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Minimum values between X and Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}