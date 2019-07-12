using System;

namespace MyCalculator.OneArgument
{
    public class PowTwoCalculator:IOneArgumentCalculator
    {
        /// <summary>
        ///  2 power X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(2,firstValue);
            return result;
        }
    }
}