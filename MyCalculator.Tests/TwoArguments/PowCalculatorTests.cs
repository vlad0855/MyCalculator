using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 1, 3)]
        [TestCase(2, 0, 1)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            PowCalculator powCalculator = new PowCalculator();
            double result = powCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}