using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]

    public class MultiplyCalculatorTests
    {

        [Test]
        public void CalculateTests()
        {
            MultiplyCalculator multiplyCalculator = new MultiplyCalculator();
            double result = multiplyCalculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}