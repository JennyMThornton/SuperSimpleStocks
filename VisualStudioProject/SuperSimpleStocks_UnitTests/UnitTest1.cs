using System;
using System.Collections.Generic;
using SuperSimpleStocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperSimpleStocks_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
   
        [TestMethod]
        public void TestGeometricMean()
        {
            List<Stock> stockData = CreateTestStockList();

            float meanVal = Stock.GeometricMean(stockData);

            Assert.IsTrue(meanVal> 108.4471&& meanVal <108.4472);
        }
        [TestMethod]
        public void TestStockPriceCalculation()
        {
            List<TradeRecord> tradeData = CreateTestTradeList("TEA");
            float meanVal = Stock.CalculateStockPrice(tradeData);

            Assert.IsTrue(meanVal == 137);
        }
        [TestMethod]
        public void Test_P_to_E_Ratio()
        {
            
            float resultVal = Stock.P_to_E_Ratio(132,20);

            Assert.IsTrue(ApproxEquals(resultVal, 6.6f));
        }

        [TestMethod]
        public void PreferedDividendYield()
        {
            float resultVal = Stock.PreferedDividendYield(0.08f,100, 160);
           
            Assert.IsTrue(ApproxEquals(resultVal, 0.05f));
        }
        [TestMethod]
        public void PreferedCommonYield()
        {
            float resultVal = Stock.CommonDividendYield(24, 160);

            Assert.IsTrue(ApproxEquals(resultVal, 0.15f));
        }
        List<TradeRecord> CreateTestTradeList(string stockSymbol)
        {
            List<TradeRecord> tradeData = new List<TradeRecord>(5);
            tradeData.Add(new TradeRecord(stockSymbol, DateTime.UtcNow,
                100,130, TradeRecord.TradeTypes.Buy));
            tradeData.Add(new TradeRecord(stockSymbol, DateTime.UtcNow-TimeSpan.FromMinutes(1), 
                80, 140, TradeRecord.TradeTypes.Buy));
            tradeData.Add(new TradeRecord(stockSymbol, DateTime.UtcNow - TimeSpan.FromMinutes(4),
                1000, 135, TradeRecord.TradeTypes.Sell));
            tradeData.Add(new TradeRecord(stockSymbol, DateTime.UtcNow - TimeSpan.FromMinutes(8),
                200, 150, TradeRecord.TradeTypes.Buy));
            tradeData.Add(new TradeRecord(stockSymbol, DateTime.UtcNow - TimeSpan.FromMinutes(16),
                100, 140, TradeRecord.TradeTypes.Sell));

            return tradeData;
        }
        List<Stock> CreateTestStockList()
        {
            List<Stock> stockData = new List<Stock>(5);
            stockData.Add(new Stock("TEA", Stock.StockTypes.Common, 0, 0, 100));
            stockData.Add(new Stock("POP", Stock.StockTypes.Common, 8, 0, 100));
            stockData.Add(new Stock("ALE", Stock.StockTypes.Common, 23, 0, 60));
            stockData.Add(new Stock("GIN", Stock.StockTypes.Preferred, 8, 2, 100));
            stockData.Add(new Stock("JOE", Stock.StockTypes.Common, 13, 0, 250));

            return stockData;
        }
        bool ApproxEquals(float val1, float val2)
        {
            float remainder = val1 - val2;
            if (Math.Abs(remainder) < 0.0001f)
            {
                return true;
            }

            return false;
        }
    }
}
