using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class SinCalculatorTests
    {

        [TestCase(2, 0.909)]
        [TestCase(1.2, 0.932)]
        [TestCase(-2, -0.909)]
        public void CalculateTests(double firstValue,double expected)
        {
            SinCalculator sinCalculator = new SinCalculator();
            double result = sinCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
