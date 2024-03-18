using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Parser;

namespace Calculator
{
    internal class Calculations
    {
        public Calculations()
        {

        }
        public string Calculate(string a, Operators operation, string b)
        {
            double _a = double.Parse(a);
            double _b = double.Parse(b);

            switch (operation)
            {
                case Operators s when s == Operators.Addition:
                    return $"{_a + _b}";
                case Operators s when s == Operators.Subtraction:
                    return $"{_a - _b}";
                case Operators s when s == Operators.Multiplication:
                    return $"{_a * _b}";
                case Operators s when s == Operators.Division:
                    return $"{_a / _b}";
                default:
                    throw new Exception("Unreachable");
            }
        }
    }
}
