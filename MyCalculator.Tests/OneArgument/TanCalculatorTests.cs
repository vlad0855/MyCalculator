using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class TanCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(10, 0.648)]
        [TestCase(-6.8, -0.568)]
        public void CalculateTests(double firstValue, double expected)
        {
            TanCalculator tanCalculator = new TanCalculator();
            double result = tanCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}