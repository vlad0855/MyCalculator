using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class SubstractionCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            SubstractionCalculator substractionCalculator = new SubstractionCalculator();
            double result = substractionCalculator.Calculate(2, 2);
            Assert.AreEqual(0, result);
        }
    }
}
