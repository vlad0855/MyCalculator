using System;

namespace MyCalculator.TwoArguments
{
    public class DivisionCalculator:ITwoArgumentsCalculator
    {
        /// <summary>
        /// Division X by Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
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
