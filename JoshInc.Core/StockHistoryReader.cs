using System;
using System.Globalization;
using System.IO;

namespace JoshInc.Core
{
    public class StockHistoryReader
    {
        public StockHistoryReader()
        {
            
        }

        public StockHistory LoadFile()
        {
            //List<SharePrice> sharePrices = new List<SharePrice>();
            StockHistory stockHistory = new StockHistory();

            FileStream file = File.Open(@"C:\Users\Paul\documents\visual studio 2017\Projects\JoshInc\JoshInc.Core\AAPL.csv", FileMode.Open);

            var reader = new StreamReader(file);

            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                
                var sharePrice = new SharePrice
                {
                    Date = DateTime.ParseExact(values[0], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Symbol = "APPL",
                    Open = double.Parse(values[1]),
                    High = double.Parse(values[2]),
                    Low = double.Parse(values[3]),
                    Close = double.Parse(values[4])
                };

                //sharePrices.Add(sharePrice);
                stockHistory.AddSharePrice(sharePrice);
            }

            //return sharePrices;
            return stockHistory;
        }
 
    }
}