using MyCalculator.OneArgument;
using NUnit.Framework;
using System;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class ArccosCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.571)]
        [TestCase(-1, 3.142)]
        public void CalculateTests(double firstValue, double expected)
        {
            ArccosCalculator arccosCalculator = new ArccosCalculator();
            double result = arccosCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }

        [Test]
        public void NegativeCalculateTests()
        {
            ArccosCalculator arccosCalculator = new ArccosCalculator();
            Assert.Throws<Exception>(() => arccosCalculator.Calculate(2));
        }
    }
}