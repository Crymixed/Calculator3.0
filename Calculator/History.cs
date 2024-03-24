using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    internal class History
    {
        public History() 
        {
            
        }

        List<Tuple<string, DateTime>> history = new List<Tuple<string, DateTime>>();

        public void HistoryAdd(Tuple<string> item)
        {
            history.Add(new Tuple<string, DateTime>(item.ToString(), DateTime.Now));
        }
        public void HistoryClear()
        {
            Console.WriteLine("Deleting history");
            history.Clear(); 
        }

        public void HistoryPrint()
        {
            foreach (Tuple<string, DateTime> i in history)
                Console.Write(($"{i.Item1} {i.Item2}\n"));
            Console.WriteLine("");

        }
    }
}
