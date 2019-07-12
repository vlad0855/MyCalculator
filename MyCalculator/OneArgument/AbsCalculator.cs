using System;

namespace MyCalculator.OneArgument
{

    public class AbsCalculator: IOneArgumentCalculator
    {
        /// <summary>
        /// Absolute X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Abs(firstValue);
            return result;
        }
    }
}