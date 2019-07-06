using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class PowFloatCalculatorTests
    {
        [TestCase(2, 1, 2)]
        [TestCase(3, 2, 1.732)]
        [TestCase(3, 1, 3)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            PowFloatCalculator powFloatCalculator = new PowFloatCalculator();
            double result = powFloatCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}