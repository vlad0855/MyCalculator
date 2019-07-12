namespace MyCalculator.OneArgument
{
    public class DivCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 1 divided by X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            double result = 1 / (firstValue);
            return result;
        }
    }
}