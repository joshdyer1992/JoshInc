using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshInc.Core
{
    public class StockHistory
    {
        public List<SharePrice> SharePrices { get; set; }

        public StockHistory()
        {
            SharePrices = new List<SharePrice>();
        }

        public void AddSharePrice(SharePrice sharePrice)
        {
            SharePrices.Add(sharePrice);
        }

        public double GetHighest()
        {
            var highs = SharePrices.Select(sharePrice => sharePrice.High);
            return SharePrices.Select(sharePrice => sharePrice.High).Max();
        }

        public double GetLowest()
        {
       
            return SharePrices.Select(sharePrice => sharePrice.Low).Min();
        }

    }
}


