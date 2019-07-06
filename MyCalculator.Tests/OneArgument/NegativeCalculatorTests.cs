using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class NegativeCalculatorTests
    {

        [TestCase(2, -2)]
        [TestCase(60, -60)]
        [TestCase(-2, 2)]
        public void CalculateTests(double firstValue, double expected)
        {
            NegativeCalculator negativeCalculator = new NegativeCalculator();
            double result = negativeCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}