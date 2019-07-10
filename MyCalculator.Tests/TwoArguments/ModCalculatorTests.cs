using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class  ModCalculatorTests
    {
        [Test]
        public void CalculateTests()
        {
            ModCalculator modCalculator = new ModCalculator();
            double result = modCalculator.Calculate(2, 1);
            Assert.AreEqual(0, result);
        }
    }
}