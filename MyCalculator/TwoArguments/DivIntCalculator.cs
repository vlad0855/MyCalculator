namespace MyCalculator.TwoArguments
{
    public class DivIntCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Integer division X by Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return (int)(firstValue / secondValue);
        }
    }
}