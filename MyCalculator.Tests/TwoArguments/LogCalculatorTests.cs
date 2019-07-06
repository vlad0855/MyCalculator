using System;
using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class LogCalculatorTests
    {
        [TestCase(6, 36, 2)]
        [TestCase(3, 9, 2)]
        [TestCase(2, 4, 2)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            LogCalculator logCalculator = new LogCalculator();
            double result = logCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateTests()
        {
            LogCalculator logCalculator = new LogCalculator();
            Assert.Throws<Exception>(() => logCalculator.Calculate(4,1));
        }
    }
}


