using System;

namespace MyCalculator.TwoArguments
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Plus":
                    return new AdditionCalculator();
                case "Minus":
                    return new SubstractionCalculator();
                case "Multiplication":
                    return new MultiplyCalculator();
                case "Division":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
