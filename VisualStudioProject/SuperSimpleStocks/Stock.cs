using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSimpleStocks
{
    public partial class Stock
    {
        public enum StockTypes
        {
            None=0,
            Common = 1,
            Preferred = 2,
        }
        int m_stockID;
        string m_stockSymbol;
        StockTypes m_stockType;
        int m_lastDividend;
        int m_parValue;
        float m_fixedDividend;
        #region properties
        internal string StockSymbol
        {
            get
            {
                return m_stockSymbol;
            }
        }
        internal StockTypes StockType
        {
            get
            {
                return m_stockType;
            }
        }
        internal int LastDividend
        {
            get
            {
                return m_lastDividend;
            }
        }

        internal int ParValue
        {
            get
            {
                return m_parValue;
            }
        }

        

        internal float FixedDividend
        {
            get
            {
                return m_fixedDividend;
            }
        }

        internal int StockPrice
        {
            get
            {
                return CalculateStockPrice();
            }
        }
        internal int TotalLastDividend
        {
            get
            {
                int lastDividend = m_lastDividend;
                if (m_stockType == StockTypes.Preferred)
                {
                    lastDividend += (int)Math.Floor(m_parValue* m_fixedDividend);
                }
                return lastDividend;
            }
        }
        #endregion //properties end

        public Stock(string stockSymbol, StockTypes stockType, int lastDividend, float fixedDividendPercentage, int parValue)
        {
            SetUp( stockSymbol, stockType, lastDividend, fixedDividendPercentage*0.01f, parValue);
        }

        void SetUp(string stockSymbol, StockTypes stockType, int lastDividend, float fixedDividend, int parValue)
        {

            m_stockSymbol = stockSymbol;
            m_stockType = stockType;
            m_lastDividend = lastDividend;
            m_parValue = parValue;
            m_fixedDividend = fixedDividend;
        }


        #region methods
        public float CalculateDividendYield()
        {

            switch (m_stockType)
            {
                case StockTypes.Common:
                return Stock.CommonDividendYield(m_lastDividend, StockPrice);
                case StockTypes.Preferred:
                return Stock.PreferedDividendYield(m_fixedDividend, m_parValue, StockPrice);
            }
            return -1;

        }

        public float CalculatePToERatio()
        {

            return Stock.P_to_E_Ratio(StockPrice, TotalLastDividend);
        }
        /// <summary>
        /// Uses previous trades to calculate the stock price
        /// </summary>
        /// <param name="numMins">max age of trades to be considered</param>
        /// <returns></returns>
        internal int CalculateStockPrice(int numMins = 0)
        {
            //Get all for the trades for this stock
            IEnumerable<TradeRecord> allTrades = Program.SimpleTradeManager.GetTradesForSymbol(m_stockSymbol, numMins);
            //if there are trades then use them to calculate the stock price
            if (allTrades.Count() > 0)
            {
                return Stock.CalculateStockPrice(allTrades);
            }
            //get the last trade
            allTrades = Program.SimpleTradeManager.GetTradesForSymbol(m_stockSymbol);
            
            if (allTrades.Count() > 0)
            {
                //order by time
                allTrades = allTrades.OrderByDescending(trade => trade.TimeStamp);
                return allTrades.First().Price;
            }
            //if there are no trades assume the par price is the current stock price
            return m_parValue;
        }
        
        #endregion //methods
    }
}
