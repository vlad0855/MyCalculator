using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public  class TwoArgumentsFactory
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
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
