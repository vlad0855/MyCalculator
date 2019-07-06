using System;
using MyCalculator.OneArgument;
using NUnit.Framework;

namespace MyCalculator.Tests.OneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTestCase
    {
        [TestCase("Abs", typeof(AbsCalculator))]
        [TestCase("Arccos", typeof(ArccosCalculator))]
        [TestCase("Arcsin", typeof(ArcsinCalculator))]
        [TestCase("Squaring", typeof(SquaringCalculator))]
        [TestCase("Cos", typeof(CosCalculator))]
        [TestCase("SQRT", typeof(SQRTCalculator))]
        [TestCase("Sin", typeof(SinCalculator))]
        [TestCase("Tan", typeof(TanCalculator))]
        [TestCase("Negative", typeof(NegativeCalculator))]
        [TestCase("Div", typeof(DivCalculator))]
        [TestCase("ExpPow", typeof(ExponentialPowCalculator))]
        [TestCase("PowTen", typeof(PowTenCalculator))]
        [TestCase("PowTwo", typeof(PowTwoCalculator))]
        [TestCase("Ctan", typeof(CtanCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}