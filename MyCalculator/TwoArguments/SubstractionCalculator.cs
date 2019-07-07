namespace MyCalculator.TwoArguments
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue - secondValue;
            return result;
        }
    }
}
