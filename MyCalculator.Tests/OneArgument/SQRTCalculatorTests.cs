using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class SQRTCalculatorTests
    {
        [TestCase(4, 2)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void CalculateTests(double firstValue, double expected)
        {
            SqrtCalculator sqrtCalculator = new SqrtCalculator();
            double result = sqrtCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}