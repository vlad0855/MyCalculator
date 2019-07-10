using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class MinCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            MinCalculator minCalculator = new MinCalculator();
            double result = minCalculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}