using MyCalculator.OneArgument;
using MyCalculator.TwoArguments;

namespace MyCalculator
{
    public class NegativeCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = -firstValue;
            return result;
        }

    }
}