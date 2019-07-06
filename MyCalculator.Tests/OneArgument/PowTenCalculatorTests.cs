using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class PowTenCalculatorTests
    {

        [TestCase(2, 100)]
        [TestCase(0, 1)]
        [TestCase(1, 10)]
        public void CalculateTests(double firstValue, double expected)
        {
            PowTenCalculator powTenCalculator = new PowTenCalculator();
            double result = powTenCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}