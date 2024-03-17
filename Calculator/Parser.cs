using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Parser
    {
        Calculations calculations = new Calculations();

        string[] split;
        public enum Operators
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }
        public Parser()
        {

        }
        public void Inputer()
        {
            Console.Write("\nInsert the math problem: ");
            string input = Console.ReadLine();
            Checker(input);
        }
        private void Checker(string input)
        {
            switch (input)
            {
                case string s when s.Contains("+"):
                    split = s.Split('+');
                    Caller(Operators.Addition);
                    break;
                case string s when s.Contains("-"):
                    split = s.Split('-');
                    Caller(Operators.Subtraction);
                    break;
                case string s when s.Contains("*"):
                    split = s.Split('*');
                    Caller(Operators.Multiplication);
                    break;
                case string s when s.Contains("/"):
                    split = s.Split('/');
                    Caller(Operators.Division);
                    break;
                default:
                    throw new ArgumentException("Incorrect or missing operation!");
            }
        }
        private void Caller(Enum operation)
        {
            Console.WriteLine(calculations.Calculate(split[0], operation, split[1])); // State check //
        }
    }
}
