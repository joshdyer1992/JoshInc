using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshInc.Core;

namespace JoshInc.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StockHistoryReader();

             StockHistory stockHistory = reader.LoadFile();

            var highest = stockHistory.GetHighest();
            var lowest = stockHistory.GetLowest();
            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Lowest: {lowest}");
            Console.ReadLine();
        }
    }


}
