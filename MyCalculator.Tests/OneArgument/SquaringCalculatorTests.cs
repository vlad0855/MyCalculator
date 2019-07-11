using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class SquaringCalculatorTests
    {
        [TestCase(2, 4)]
        [TestCase(-4, 16)]
        [TestCase(1, 1)]
        public void CalculateTests(double firstValue, double expected)
        {
            SquaringCalculator squaringCalculator = new SquaringCalculator();
            double result = squaringCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}