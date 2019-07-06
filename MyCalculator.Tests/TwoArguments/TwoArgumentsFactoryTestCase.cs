using System;
using MyCalculator.TwoArguments;
using NUnit.Framework;

namespace MyCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentFactoryTestCase
    {
        [TestCase("Log", typeof(LogCalculator))]
        [TestCase("PowFloat", typeof(PowFloatCalculator))]
        [TestCase("Min", typeof(MinCalculator))]
        [TestCase("Mod", typeof(ModCalculator))]
        [TestCase("Max", typeof(MaxCalculator))]
        [TestCase("DivInt", typeof(DivIntCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Division", typeof(DivisionCalculator))]
        [TestCase("Plus", typeof(AdditionCalculator))]
        [TestCase("Minus", typeof(SubstractionCalculator))]
        [TestCase("Multiplication", typeof(MultiplyCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}