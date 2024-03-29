﻿using System;

namespace MyCalculator.TwoArguments
{
    /// <summary>
    /// This is factory for two operation functions
    /// </summary>
    /// <returns>
    /// Returns completed calculations
    /// </returns>>
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Plus":
                    return new AdditionCalculator();
                case "Minus":
                    return new SubstractionCalculator();
                case "Multiplication":
                    return new MultiplyCalculator();
                case "Division":
                    return new DivisionCalculator();
                case "Log":
                    return new LogCalculator();
                case "Pow":
                    return new PowCalculator();
                case "PowFloat":
                    return new PowFloatCalculator();
                case "Min":
                    return new MinCalculator();
                case "Max":
                    return new MaxCalculator();
                case "Mod":
                    return new ModCalculator();
                case "DivInt":
                    return new DivIntCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
