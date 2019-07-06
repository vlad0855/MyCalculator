using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class ExponentialPowCalculatorTests
    {

        [TestCase(2, 7.389)]
        [TestCase(5, 148.413)]
        [TestCase(-2, 0.135)]
        public void CalculateTests(double firstValue, double expected)
        {
            ExponentialPowCalculator exponentialPowCalculator = new ExponentialPowCalculator();
            double result = exponentialPowCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result,0.001);
        }
    }
}