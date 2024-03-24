using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Logic
    {
        Parser parser = new Parser();
        History history = new History();
        private void CreateHistory()
        { 
            parser.history = history;
        }

        public Logic()  
        {
            CreateHistory();
        }

        public void Paths()
        {

            while (true)
            {
                Console.Write("Choose action or input math problem: " +
                "Show history \n                                     " +
                "Delete history\n                                     " +
                "Exit\n                                     " +
                "Action: ");
                switch (Console.ReadLine().ToLower())
                {
                    case string s when s.Equals("calculator"):
                        parser.Inputer();
                        break;
                    case string s when s.Equals("show history"):
                        history.HistoryPrint();
                        break;
                    case string s when s.Equals("delete history"):
                        history.HistoryClear();
                        break;
                    case string s when s.Equals("exit"):
                        Environment.Exit(0);
                        break;
                    case string s when (s.Contains((char)Parser.Operators.Addition)) || (s.Contains((char)Parser.Operators.Subtraction)) || (s.Contains((char)Parser.Operators.Multiplication)) || (s.Contains((char)Parser.Operators.Division)):
                        parser.MultipleOperators(s);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
