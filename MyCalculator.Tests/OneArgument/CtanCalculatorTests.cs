using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class CtanCalculatorTests
    {
        [TestCase(1, 0.642)]
        [TestCase(0.5, 1.830)]
        [TestCase(-1, -0.642)]
        public void CalculateTests(double firstValue, double expected)
        {
            CtanCalculator ctanCalculator = new CtanCalculator();
            double result = ctanCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}