namespace MyCalculator.TwoArguments
{
    public class ModCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Remainder of the dividing X by Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}