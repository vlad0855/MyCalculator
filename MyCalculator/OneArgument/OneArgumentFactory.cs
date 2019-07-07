﻿using System;

namespace MyCalculator.OneArgument
{
   public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string sender)
        {
            switch (sender)
            {
                case "Squaring":
                    return new SquaringCalculator();
                case "SQRT":
                    return new SqrtCalculator();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
