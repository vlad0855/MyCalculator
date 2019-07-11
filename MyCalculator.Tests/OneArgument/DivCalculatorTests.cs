using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class DivCalculatorTests
    {
        [TestCase(2, 0.5)]
        [TestCase(-5, -0.2)]
        [TestCase(1.5, 0.666)]
        public void CalculateTests(double firstValue, double expected)
        {
            DivCalculator divCalculator = new DivCalculator();
            double result = divCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}