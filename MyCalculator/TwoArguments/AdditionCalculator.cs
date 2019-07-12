namespace MyCalculator.TwoArguments
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// X plus Y
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue + secondValue;
            return result;
        }
    }
}
