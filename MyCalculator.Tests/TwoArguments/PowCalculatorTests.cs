using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            PowCalculator powCalculator = new PowCalculator();
            double result = powCalculator.Calculate(1, 2);
            Assert.AreEqual(1, result);
        }
    }
}