using System;

namespace MyCalculator.OneArgument
{
   public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Squaring":
                    return new SquaringCalculator();
                case "SQRT":
                    return new SqrtCalculator();
                case "Sin":
                    return new SinCalculator();
                case "Cos":
                    return new CosCalculator();
                case "Tan":
                    return new TanCalculator();
                case "Arcsin":
                    return new ArcsinCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
