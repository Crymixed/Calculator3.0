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
            Inputer();
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
                    Caller(Operators.Addition.ToString());
                    break;
                case string s when s.Contains("-"):
                    split = s.Split('-');
                    Caller(Operators.Subtraction.ToString());
                    break;
                case string s when s.Contains("*"):
                    split = s.Split('*');
                    Caller(Operators.Multiplication.ToString());
                    break;
                case string s when s.Contains("/"):
                    split = s.Split('/');
                    Caller(Operators.Division.ToString());
                    break;
                default:
                    throw new ArgumentException("Incorrect operation!");
            }
        }
        private void Caller(string a)
        {
            Calculations calculationss = new Calculations(float.Parse(split[0]), a, float.Parse(split[1]));
        }
    }
}
