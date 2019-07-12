using System;

namespace MyCalculator.OneArgument
{
    public class SQRTCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Square root X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Отрицательный аргумент");
            }
            double result = Math.Sqrt(firstValue);
            return result;
        }
    }
}
