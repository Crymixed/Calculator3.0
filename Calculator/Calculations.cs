using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculations
    {
        public Calculations() 
        {

        }
        public string Calculate(string a, Enum operation,string b)
        {
            float _a = float.Parse(a);
            float _b = float.Parse(b);

            switch (operation.ToString())
            {
                case string s when s.Equals("Addition"):
                    return $"{_a + _b}";
                case string s when s.Equals("Subtraction"):
                    return $"{_a - _b}";
                case string s when s.Equals("Multiplication"):
                    return $"{_a * _b}";
                case string s when s.Equals("Division"):
                    return $"{_a / _b}";
                default:
                    throw new Exception("?");
            }
        }
    }
}
