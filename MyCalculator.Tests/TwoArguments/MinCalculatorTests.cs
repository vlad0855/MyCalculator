using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class MinCalculatorTests
    {
        [TestCase(3, 9, 3)]
        [TestCase(2, 4, 2)]
        [TestCase(60, 2, 2)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            MinCalculator minCalculator = new MinCalculator();
            double result = minCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
