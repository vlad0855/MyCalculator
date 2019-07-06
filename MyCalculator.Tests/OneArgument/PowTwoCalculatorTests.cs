using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class PowTwoCalculatorTests
    {

        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        public void CalculateTests(double firstValue, double expected)
        {
            PowTwoCalculator powTwoCalculator = new PowTwoCalculator();
            double result = powTwoCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}