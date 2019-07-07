﻿using MyCalculator.OneArgument;

namespace MyCalculator
{
    public class DivCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            double result = 1 / (firstValue);
            return result;
        }
    }
}