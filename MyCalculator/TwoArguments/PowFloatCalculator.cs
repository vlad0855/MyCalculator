using System;

namespace MyCalculator.TwoArguments
{
    public class PowFloatCalculator: ITwoArgumentsCalculator
    {
        /// <summary>
        /// X power 1 division by Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, (1/secondValue));
            return result;
        }
    }
}