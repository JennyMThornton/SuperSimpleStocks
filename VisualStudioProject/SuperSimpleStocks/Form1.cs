using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSimpleStocks
{
    public partial class formSimpleStocks : Form
    {
        public formSimpleStocks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnDivYield_Click(object sender, EventArgs e)
        {
            string strOutput = "N/A";

            Stock currentStock = Program.SimpleTradeManager.GetStockForSymbol(textBox1.Text);

            if (currentStock != null)
            {
                float divYield = currentStock.CalculateDividendYield();
                strOutput = divYield.ToString();
                
            }
            else
            {
                strOutput = "";
                foreach (Stock stockEntry in Program.SimpleTradeManager.StockData)
                {
                    float pteRatio = stockEntry.CalculateDividendYield();
                    strOutput += string.Format("{0}:{1}\n", stockEntry.StockSymbol,
                       ((pteRatio > 0) ? pteRatio.ToString() : "N/A"));
                }
            }
            SetOutputString(strOutput);
        }

        private void btnP_E_Rat_Click(object sender, EventArgs e)
        {
            string strOutput = "N/A";

            Stock currentStock = Program.SimpleTradeManager.GetStockForSymbol(textBox1.Text);

            if (currentStock != null)
            {
                float pteRatio = currentStock.CalculatePToERatio();
                if (pteRatio > 0)
                {
                    strOutput = pteRatio.ToString();
                }

            }
            else
            {
                strOutput = "";
                foreach (Stock stockEntry in Program.SimpleTradeManager.StockData)
                {
                    float pteRatio = stockEntry.CalculatePToERatio();
                    strOutput += string.Format("{0}:{1}\n", stockEntry.StockSymbol,
                       ((pteRatio > 0)? pteRatio.ToString():"N/A"));
                }
            }
            SetOutputString(strOutput);
        }

        private void btnTradeGen_Click(object sender, EventArgs e)
        {
            int numTrades;
            Int32.TryParse(txtRandomQuantity.Text, out numTrades);
            if (numTrades <= 0)
            {
                numTrades = 1;
            }
            Program.SimpleTradeManager.RegisterFakeTrades(numTrades, textBox1.Text, 50);
            SetOutputString(string.Format("{0} Fake Trades Registered, New Total Trade Count : {1}", numTrades, Program.TradeData.Count));
        }

        private void btnStockPrice_Click(object sender, EventArgs e)
        {
            string strOutput = "N/A";
            Stock currentStock = Program.SimpleTradeManager.GetStockForSymbol(textBox1.Text);

            if (currentStock != null)
            {
                float price = currentStock.CalculateStockPrice(15);
                strOutput = price.ToString();
                

            }
            //show all stocks
            else
            {
                strOutput = "";
                foreach (Stock stockEntry in Program.SimpleTradeManager.StockData)
                {
                    strOutput += string.Format("{0}:{1}\n", stockEntry.StockSymbol, stockEntry.StockPrice);
                }

            }
            SetOutputString(strOutput);
        }
        private void btnCalculateGBCE_Click(object sender, EventArgs e)
        {
            float gbce = Program.SimpleTradeManager.CalculateGBCE();
            SetOutputString(gbce.ToString());
        }
        internal void SetOutputString(string strOutput)
        {
            lblOutput.Text = strOutput;
            Program.LogDebug(strOutput);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            TradeStock(TradeRecord.TradeTypes.Buy);
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            TradeStock(TradeRecord.TradeTypes.Sell);
        }
        void TradeStock(TradeRecord.TradeTypes tradeType)
        {
            string stockSymbol = txtTradeSymbol.Text;

            Stock currentStock = Program.SimpleTradeManager.GetStockForSymbol(stockSymbol);
            if (currentStock == null)
            {
                SetOutputString("Stock not found");
            }

            int price;
            int.TryParse(txtTradePrice.Text, out price);

            int quantity;
            int.TryParse(txtTradeQuantiy.Text, out quantity);

            if (price == 0)
            {
                price = currentStock.StockPrice;
            }
            if (quantity == 0)
            {
                quantity = 1;
            }

            TradeRecord newRecord = new TradeRecord(currentStock.StockSymbol, DateTime.UtcNow, quantity, price, tradeType);
            Program.SimpleTradeManager.RegisterTrade(newRecord);
            SetOutputString(string.Format("Trade Completed : {0}", newRecord.ToString()));

        }


    }
}
