using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSimpleStocks
{
    partial class Stock
    {
        public static float CommonDividendYield(int lastDividend, int price)
        {
            float result = lastDividend /(float)price;

            return result;
        }

        public static float PreferedDividendYield(float fixedDividend, int parValue, int price)
        {
            float result = (fixedDividend*parValue) / (float)price;

            return result;
        }
        public static float P_to_E_Ratio(int price, int dividend)
        {
            if (dividend != 0)
            {
                float result = price / (float)dividend;

                return result;
            }
            // there are no earnings
            return -1;
        }

        static internal float GeometricMean(List<float> prices)
        {
            double runningTotal = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                runningTotal *= prices[i];
            }

            return (float)Math.Sqrt(runningTotal);
        }
        public static float GeometricMean(List<Stock> allStocks)
        {
            double runningTotal = 0;
            if (allStocks.Count > 0)
            {
                runningTotal = allStocks[0].StockPrice;
            }

            for (int i = 1; i < allStocks.Count; i++)
            {
                runningTotal *= allStocks[i].StockPrice;
            }

            return (float)Math.Pow(runningTotal, 1.0/ allStocks.Count);
        }
        public static int CalculateStockPrice(IEnumerable<TradeRecord> tradeList)
        {
            double runningTotal = 0;
            double quantityTotal = 0;
            foreach (TradeRecord currentRecord in tradeList)
            {
                runningTotal += (currentRecord.Price * currentRecord.Quantity);
                quantityTotal += currentRecord.Quantity;           
            }

            return (int)Math.Floor(runningTotal / quantityTotal);
        }

    }
}
