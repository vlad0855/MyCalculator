using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivIntCalculatorCalculatorTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 0)]
        [TestCase(21, 4, 5)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            DivIntCalculator divIntCalculator = new DivIntCalculator();
            double result = divIntCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}