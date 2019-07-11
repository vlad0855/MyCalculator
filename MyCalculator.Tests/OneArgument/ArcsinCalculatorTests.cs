using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]

    public class ArcsinCalculatorTests
    {
        [TestCase(1, 1.571)]
        [TestCase(0, 0)]
        [TestCase(-1, -1.571)]
        public void CalculateTests(double firstValue, double expected)
        {
            ArcsinCalculator arcsinCalculator = new ArcsinCalculator();
            double result = arcsinCalculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}