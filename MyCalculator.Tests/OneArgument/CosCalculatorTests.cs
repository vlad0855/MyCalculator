using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class CosCalculatorTests
    {
        [TestCase(1, 0.540)]
        [TestCase(0, 1)]
        [TestCase(-16, -0.958)]
        public void CalculateTests(double firstValue, double expected)
        {
            CosCalculator cosCalculator = new CosCalculator();
            double result = cosCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}