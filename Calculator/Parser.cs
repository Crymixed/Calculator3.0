using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Parser
    {
        Calculations calculations = new Calculations();
        public History history;

        string[] split;
        public enum Operators : ushort
        {
            Addition = '+',
            Subtraction = '-',
            Multiplication = '*',
            Division = '/',
        }
        public Parser()
        {

        }
        public void Inputer()
        {
            string input = Console.ReadLine();

            MultipleOperators(input);
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
        private void Caller(Operators operation)
        {
            string fill = calculations.Calculate(split[0], operation, split[1]);
            Console.WriteLine(fill);
            history.HistoryAdd(Tuple.Create($"{split[0]}{(char)operation}{split[1]} = {fill}"));
        }

        public void MultipleOperators(string input)
        {
            var operatorcount = 0;
            var numbcount = 0;
            var afterOperatorEnable = false;
            var operatorWork = false;
            var containsLetter = false;
            foreach (char c in input)
            {
                if ((c == '+') || (c == '-') || (c == '*') || (c == '/'))
                {
                    operatorcount++;
                    if (numbcount > 0)
                        afterOperatorEnable = true;
                }

                if (char.IsDigit(c))
                {
                    if (afterOperatorEnable == true)
                    {
                        numbcount++;
                        operatorWork = true;
                    }
                    else
                    {
                        numbcount++;
                    }
                }
                else
                {
                    containsLetter = true;
                }
            }
            if (operatorcount == 1 && numbcount >= 2 && operatorWork == true && !containsLetter)
                Checker(input);
            else if (containsLetter)
                Console.WriteLine("Input contains a letter");
            else if (operatorcount > 1)
                Console.WriteLine("Multiple operators not suported");
            else if ((numbcount < 2) || (numbcount >= 2 && operatorWork == false))
                Console.WriteLine("At least 2 numbers required");
            else Console.WriteLine("Error");
        }
    }
}
