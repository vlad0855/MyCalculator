﻿using System;

namespace MyCalculator.OneArgument
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Acos X
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < -1 || firstValue > 1)
            {
                throw new Exception("Аргумент функции Arccos не должен быть больше 1 и не должен быть < -1 ");
            }
            double result = Math.Acos(firstValue);
            return result;
        }
    }
}