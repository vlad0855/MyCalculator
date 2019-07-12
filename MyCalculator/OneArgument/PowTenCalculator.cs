using System;

namespace MyCalculator.OneArgument
{
    public class PowTenCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// 10 power X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = Math.Pow(10, firstValue);
            return result;
        }
    }
}