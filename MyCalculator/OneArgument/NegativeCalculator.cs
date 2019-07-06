namespace MyCalculator.OneArgument
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