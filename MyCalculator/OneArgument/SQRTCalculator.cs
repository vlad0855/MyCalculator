using System;

namespace MyCalculator.OneArgument
{
    public class SQRTCalculator : IOneArgumentCalculator
    {
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
