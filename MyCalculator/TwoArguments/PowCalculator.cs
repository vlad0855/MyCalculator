using System;

namespace MyCalculator.TwoArguments
{
    public class PowCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// X power Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            return result;
        }
    }
}