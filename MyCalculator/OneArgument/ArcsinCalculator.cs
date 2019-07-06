using System;

namespace MyCalculator.OneArgument
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Аргумент функции Arcsin не должен быть больше 1 и не должен быть < -1 ");
            }
            double result = Math.Asin(firstValue);
            return result;
        }
    }
}