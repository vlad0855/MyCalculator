using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class LogCalculatorTests
    {
        [TestCase(2, 1, 0)]
        [TestCase(3, 9, 2)]
        [TestCase(2, 4, 2)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            LogCalculator logCalculator = new LogCalculator();
            double result = logCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}


