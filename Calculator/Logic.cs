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
        public Logic()
        {

        }
        public void Paths()
        {

            while (true)
            {
                Console.Write("Choose action: Calculator \n               Show history \n               Delete history\n               Exit\nAction: ");
                switch (Console.ReadLine().ToLower())
                {
                    case string s when s.Equals("calculator"):
                        parser.Inputer();
                        break;
                    case string s when s.Equals("show history"):
                        //Show history()
                        break;
                    case string s when s.Equals("delete history"):
                        //Delete history()
                        break;
                    case string s when s.Equals("exit"):
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
