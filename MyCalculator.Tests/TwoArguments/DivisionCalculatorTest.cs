using System;
using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class DivisionCalculatorTest
    {
        [Test]
        public void CalculateTests()
        {
            DivisionCalculator divisionCalculator = new DivisionCalculator();
            double result = divisionCalculator.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void NegativeCalculateTests()
        {
            DivisionCalculator divisionCalculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => divisionCalculator.Calculate(1, 0));
        }
    }
}