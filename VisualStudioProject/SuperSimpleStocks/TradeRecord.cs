using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSimpleStocks
{
    public class TradeRecord
    {
        public enum TradeTypes
        {
            None = 0,
            Buy = 1,
            Sell = 2
        }

        string m_stockSymbol;
        DateTime m_timeStamp;
        int m_quantity;
        int m_price;
        TradeTypes m_tradeType;

       
        public string StockSymbol
        {
            get
            {
                return m_stockSymbol;
            }
        }
        public DateTime TimeStamp
        {
            get
            {
                return m_timeStamp;
            }
        }

        public int Quantity
        {
            get
            {
                return m_quantity;
            }
        }

        public int Price
        {
            get
            {
                return m_price;
            }
        }

        public TradeTypes TradeType
        {
            get
            {
                return m_tradeType;
            }
        }
        public TradeRecord(string stockSymbol, DateTime timeStamp, int quantity, int price, TradeTypes tradeType)
        {
            SetUp(stockSymbol, timeStamp, quantity, price, tradeType);
        }
        void SetUp(string stockSymbol, DateTime timeStamp, int quantity, int price, TradeTypes tradeType)
        {
            m_stockSymbol = stockSymbol;
            m_timeStamp=timeStamp;
            m_quantity= quantity;
            m_price=price;
            m_tradeType=tradeType;
        }

        public override string ToString()
        {
            return string.Format("TradeRecord {4} {0} {1} Q={2} P={3}", m_stockSymbol, m_timeStamp.ToString(),
                m_quantity, m_price, m_tradeType.ToString());
   
        }
    }
}
