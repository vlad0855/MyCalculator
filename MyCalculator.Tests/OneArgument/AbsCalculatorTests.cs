using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class AbsCalculatorTests
    {
        [TestCase(-1, 1)]
        [TestCase(1, 1)]
        [TestCase(-1.5, 1.5)]
        public void CalculateTests(double firstValue, double expected)
        {
            AbsCalculator absCalculator = new AbsCalculator();
            double result = absCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}