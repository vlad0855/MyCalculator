using System;

namespace MyCalculator.TwoArguments
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Maximum values between X and Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}