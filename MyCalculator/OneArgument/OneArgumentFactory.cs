using System;

namespace MyCalculator.OneArgument
{
    /// <summary>
    /// This factory for one operation functions
    /// </summary>
    /// <returns>
    /// Returns completed calculation
    /// </returns>>
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Squaring":
                    return new SquaringCalculator();
                case "SQRT":
                    return new SQRTCalculator();
                case "Sin":
                    return new SinCalculator();
                case "Cos":
                    return new CosCalculator();
                case "Tan":
                    return new TanCalculator();
                case "Arcsin":
                    return new ArcsinCalculator();
                case "Arccos":
                    return new ArccosCalculator();
                case "Ctan":
                    return new CtanCalculator();
                case "Abs":
                    return new AbsCalculator();
                case "Div":
                    return new DivCalculator();
                case "Negative":
                    return new NegativeCalculator();
                case "PowTwo":
                    return new PowTwoCalculator();
                case "PowTen":
                    return new PowTenCalculator();
                case "ExpPow":
                    return new ExponentialPowCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
