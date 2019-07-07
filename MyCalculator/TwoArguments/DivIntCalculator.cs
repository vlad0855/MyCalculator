using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class DivIntCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (int)(firstValue / secondValue);
        }
    }
}