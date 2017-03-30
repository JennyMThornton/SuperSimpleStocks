using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSimpleStocks
{
    class TradeManager
    {
        /// <summary>
        /// List of all Stocks
        /// </summary>
        List<Stock> m_stockData;
        /// <summary>
        /// List of all trade Data
        /// </summary>
        List<TradeRecord> m_tradeData = new List<TradeRecord>();
        /// <summary>
        /// used for random trade generation
        /// </summary>
        Random m_randomHandler = new Random();

        /// <summary>
        /// List of all Stocks
        /// </summary>
        internal List<Stock> StockData
        {
            get
            {
                return m_stockData;
            }
        }
        /// <summary>
        /// List of all trade Data
        /// </summary>
        internal List<TradeRecord> TradeData
        {
            get
            {
                return m_tradeData;
            }
        }
        internal TradeManager()
        {
            
        }

        internal static TradeManager CreateTestTradeManager()
        {
            TradeManager testManager = new TradeManager();
            testManager.SetUpDebugStockData();

            return testManager;
        }
        /// <summary>
        /// creates test Data
        /// </summary>
        void SetUpDebugStockData()
        {
            m_stockData = new List<Stock>(5);
            m_stockData.Add(new Stock("TEA", Stock.StockTypes.Common, 0, 0, 100));
            m_stockData.Add(new Stock("POP", Stock.StockTypes.Common, 8, 0, 100));
            m_stockData.Add(new Stock("ALE", Stock.StockTypes.Common, 23, 0, 60));
            m_stockData.Add(new Stock("GIN", Stock.StockTypes.Preferred, 8, 2, 100));
            m_stockData.Add(new Stock("JOE", Stock.StockTypes.Common, 13, 0, 250));
        }
        /// <summary>
        /// Get the stock entry for a given Stock Symbol
        /// </summary>
        /// <param name="symbol">Stock Symbol</param>
        /// <returns>first Stock entry with Stock Symbol</returns>
        internal Stock GetStockForSymbol(string symbol)
        {
            IEnumerable<Stock> query = from Stock stock in StockData
                                       where stock.StockSymbol == symbol
                                       select stock;

            if (query.Count() > 0)
            {
                return query.First();
            }


            return null;
        }
        /// <summary>
        /// Returns all trades for stock with a matching stock symbol
        /// Optional paramaters can be used to filter search further
        /// </summary>
        /// <param name="symbol">Stock Symbol</param>
        /// <param name="numMins">max age of trade in minutes before current time, 0 to ignore filter</param>
        /// <param name="tradeType">Type of trades, None to ignore filter</param>
        /// <returns></returns>
        internal IEnumerable<TradeRecord> GetTradesForSymbol(string symbol, 
            int numMins = 0,
            TradeRecord.TradeTypes tradeType = TradeRecord.TradeTypes.None)
        {
            IEnumerable<TradeRecord> query = from TradeRecord trade in TradeData
                                             where trade.StockSymbol == symbol
                                             select trade;
            //check in time range
            if (numMins > 0)
            {
                query = query.Where(trade => trade.TimeStamp > (DateTime.UtcNow - TimeSpan.FromMinutes(numMins)));
            }
            //check for trade type
            if (tradeType != TradeRecord.TradeTypes.None)
            {
                query = query.Where(trade => trade.TradeType == tradeType);

            }
            return query;

        }
        /// <summary>
        /// Add a trade to the list of all trades
        /// </summary>
        /// <param name="newTrade"></param>
        internal void RegisterTrade(TradeRecord newTrade)
        {
            m_tradeData.Add(newTrade);
        }
        /// <summary>
        /// Creates a number of fake trades
        /// </summary>
        /// <param name="numTrades">Number of fake trades to create</param>
        /// <param name="stockSymbol">empty string allows random stock to be chosen</param>
        /// <param name="minRange">max number of minutes in the past that the record can be time stamped with</param>
        internal void RegisterFakeTrades(int numTrades, string stockSymbol = "", int minRange=0)
        {
            for (int i = 0; i < numTrades; i++)
            {
                TradeRecord newRecord = MakeFakeTrade(stockSymbol, minRange);
                Program.LogDebug("FakeTrade:" + newRecord.ToString());
                RegisterTrade(newRecord);
            }
        }
        /// <summary>
        /// Create a random record
        /// optional paramaters can be used to vary results
        /// </summary>
        /// <param name="stockSymbol">empty string allows random stock to be chosen</param>
        /// <param name="minRange">max number of minutes in the past that the record can be time stamped with</param>
        /// <returns></returns>
        internal TradeRecord MakeFakeTrade(string stockSymbol="", int minRange = 0)
        {

            Stock tradedStock = null;
            //find the record for the stock
            if (stockSymbol != "")
            {
                tradedStock = GetStockForSymbol(stockSymbol);
            }
            else
            {
                //chose a random stock
                tradedStock = m_stockData[m_randomHandler.Next(0, m_stockData.Count)];
            }
            //error catch
            if (tradedStock == null)
            {
                return null;
            }
            //Random trade time
            DateTime timeOfTrade = (minRange > 0) ?
                DateTime.UtcNow - TimeSpan.FromMinutes(16+m_randomHandler.Next(minRange+1)) : 
                DateTime.UtcNow;
            //random price variation using the par value as a min value
            int price = Math.Max(tradedStock.ParValue, tradedStock.StockPrice + m_randomHandler.Next(-5, 10));
            //random buy or sell
            TradeRecord.TradeTypes currentType = (m_randomHandler.Next(100) > 50) ?
                TradeRecord.TradeTypes.Buy : 
                TradeRecord.TradeTypes.Sell;

            //create the trade
            TradeRecord newTrade = new TradeRecord(tradedStock.StockSymbol, timeOfTrade, m_randomHandler.Next(1, 1000), price, currentType);

            return newTrade;
        }
        internal float CalculateGBCE()
        {
            float result = Stock.GeometricMean(m_stockData);

            return result;
        }
    }
   
}
