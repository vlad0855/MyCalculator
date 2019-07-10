using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class LogCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            LogCalculator logCalculator = new LogCalculator();
            double result = logCalculator.Calculate(2, 1);
            Assert.AreEqual(0, result);
        }
    }
}