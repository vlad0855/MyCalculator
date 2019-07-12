namespace MyCalculator.TwoArguments
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Multiplying X by Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue * secondValue;
            return result;
        }
    }
}
