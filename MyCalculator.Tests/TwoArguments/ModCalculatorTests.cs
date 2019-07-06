using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class  ModCalculatorTests
    {
        [TestCase(5, 2, 1)]
        [TestCase(4, 6, 4)]
        [TestCase(5, 2, 1)]
        public void CalculateTests(double firstValue, double secondValue, double expected)
        {
            ModCalculator modCalculator = new ModCalculator();
            double result = modCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}