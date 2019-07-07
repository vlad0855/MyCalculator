using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            AdditionCalculator additionCalculator = new AdditionCalculator();
            double result = additionCalculator.Calculate(1, 2);
            Assert.AreEqual(3,result);
        }
    }
}