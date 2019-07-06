﻿using System;

namespace MyCalculator.OneArgument
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = Math.Tan(firstValue);
            return result;
        }
    }
}