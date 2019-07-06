namespace MyCalculator.TwoArguments
{
    public class ModCalculator:ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}