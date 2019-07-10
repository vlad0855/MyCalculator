using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class MaxCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            MaxCalculator maxCalculator = new MaxCalculator();
            double result = maxCalculator.Calculate(4, 2);
            Assert.AreEqual(4, result);
        }
    }
}