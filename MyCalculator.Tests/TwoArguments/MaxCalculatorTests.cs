using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class MaxCalculatorTests
    {
        [TestCase(3, 9, 9)]
        [TestCase(2, 4, 4)]
        [TestCase(60, 2, 60)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            MaxCalculator maxCalculator = new MaxCalculator();
            double result = maxCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}


