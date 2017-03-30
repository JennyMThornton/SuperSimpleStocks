using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Tracing;

namespace SuperSimpleStocks
{
    static class Program
    {
        static TradeManager m_simpleTradeManager = TradeManager.CreateTestTradeManager();
 
        

        internal static List<Stock> StockData
        {
            get
            {
                return SimpleTradeManager.StockData;
            }
        }

        internal static List<TradeRecord> TradeData
        {
            get
            {
                return SimpleTradeManager.TradeData;
            }
        }

        internal static TradeManager SimpleTradeManager
        {
            get
            {
                return m_simpleTradeManager;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formSimpleStocks());
            
        }

        static internal void LogDebug(string strVal)
        {
            Console.WriteLine(strVal);
        }
   
 
       
    }
}
