using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivIntCalculatorCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            DivIntCalculator divIntCalculator = new DivIntCalculator();
            double result = divIntCalculator.Calculate(3, 2);
            Assert.AreEqual(1, result);
        }
    }
}
