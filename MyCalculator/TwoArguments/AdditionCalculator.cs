namespace MyCalculator.TwoArguments
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            double result = firstValue + secondValue;
            return result;
        }
    }
}
