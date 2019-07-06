using System;

namespace MyCalculator.TwoArguments
{
    public class LogCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue < 0 || secondValue == 1)
            {
                throw  new Exception("Основание логарифма не должно быть меньше нуля и не должно равняться 1");
            }
            double result = Math.Log(secondValue,firstValue);
            return result;
        }
    }
}