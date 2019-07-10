using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class PowFloatCalculatorTests
    {

        [Test]
        public void CalculateTests()
        {
            PowFloatCalculator powFloatCalculator = new PowFloatCalculator();
            double result = powFloatCalculator.Calculate(2, 1);
            Assert.AreEqual(2, result);
        }
    }
}