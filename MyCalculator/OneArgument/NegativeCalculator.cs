namespace MyCalculator.OneArgument
{
    public class NegativeCalculator:IOneArgumentCalculator
    {
        /// <summary>
        /// Negative X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = -firstValue;
            return result;
        }

    }
}