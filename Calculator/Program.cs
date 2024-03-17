using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();
            while (true)
            {
                Console.Write("\nChoose action: Repeat \n               Show history \n               Delete history\n               Exit\nAction: ");
                switch (Console.ReadLine())
                {
                    case string s when s.ToLower().Equals("repeat"):
                        parser.Inputer();
                        break;
                    case string s when s.ToLower().Equals("show history"):
                        //Show history()
                        break;
                    case string s when s.ToLower().Equals("delete history"):
                        //Delete history()
                        break;
                    case string s when s.ToLower().Equals("exit"):
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
