namespace MyCalculator.TwoArguments
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Subtract Y from X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue - secondValue;
            return result;
        }
    }
}