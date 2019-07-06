using System;

namespace MyCalculator.TwoArguments
{
    public class DivisionCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            double result = firstValue / secondValue;
            return result;
        }
    }
}
