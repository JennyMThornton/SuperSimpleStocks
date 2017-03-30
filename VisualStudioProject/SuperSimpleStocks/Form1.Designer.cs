namespace SuperSimpleStocks
{
    partial class formSimpleStocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnP_E_Rat;
            System.Windows.Forms.Button btnTradeGen;
            System.Windows.Forms.Button btnStockPrice;
            this.lblOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDivYield = new System.Windows.Forms.Button();
            this.btnCalculateGBCE = new System.Windows.Forms.Button();
            this.lblStockSymbol = new System.Windows.Forms.Label();
            this.txtRandomQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTradeQuantiy = new System.Windows.Forms.TextBox();
            this.txtTradePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeSymbol = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            btnP_E_Rat = new System.Windows.Forms.Button();
            btnTradeGen = new System.Windows.Forms.Button();
            btnStockPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP_E_Rat
            // 
            btnP_E_Rat.Location = new System.Drawing.Point(254, 25);
            btnP_E_Rat.Name = "btnP_E_Rat";
            btnP_E_Rat.Size = new System.Drawing.Size(106, 24);
            btnP_E_Rat.TabIndex = 3;
            btnP_E_Rat.Text = "P/E Ratio";
            btnP_E_Rat.UseVisualStyleBackColor = true;
            btnP_E_Rat.Click += new System.EventHandler(this.btnP_E_Rat_Click);
            // 
            // btnTradeGen
            // 
            btnTradeGen.Location = new System.Drawing.Point(142, 96);
            btnTradeGen.Name = "btnTradeGen";
            btnTradeGen.Size = new System.Drawing.Size(330, 43);
            btnTradeGen.TabIndex = 4;
            btnTradeGen.Text = "Generate Random Trades";
            btnTradeGen.UseVisualStyleBackColor = true;
            btnTradeGen.Click += new System.EventHandler(this.btnTradeGen_Click);
            // 
            // btnStockPrice
            // 
            btnStockPrice.Location = new System.Drawing.Point(254, 56);
            btnStockPrice.Name = "btnStockPrice";
            btnStockPrice.Size = new System.Drawing.Size(106, 24);
            btnStockPrice.TabIndex = 5;
            btnStockPrice.Text = "Stock Price";
            btnStockPrice.UseVisualStyleBackColor = true;
            btnStockPrice.Click += new System.EventHandler(this.btnStockPrice_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(9, 250);
            this.lblOutput.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblOutput.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(500, 17);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = " Output";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnDivYield
            // 
            this.btnDivYield.Location = new System.Drawing.Point(142, 25);
            this.btnDivYield.Name = "btnDivYield";
            this.btnDivYield.Size = new System.Drawing.Size(106, 55);
            this.btnDivYield.TabIndex = 2;
            this.btnDivYield.Text = "Dividend Yield";
            this.btnDivYield.UseVisualStyleBackColor = true;
            this.btnDivYield.Click += new System.EventHandler(this.btnDivYield_Click);
            // 
            // btnCalculateGBCE
            // 
            this.btnCalculateGBCE.Location = new System.Drawing.Point(366, 25);
            this.btnCalculateGBCE.Name = "btnCalculateGBCE";
            this.btnCalculateGBCE.Size = new System.Drawing.Size(106, 55);
            this.btnCalculateGBCE.TabIndex = 6;
            this.btnCalculateGBCE.Text = "Calculate GBCE";
            this.btnCalculateGBCE.UseVisualStyleBackColor = true;
            this.btnCalculateGBCE.Click += new System.EventHandler(this.btnCalculateGBCE_Click);
            // 
            // lblStockSymbol
            // 
            this.lblStockSymbol.AutoSize = true;
            this.lblStockSymbol.Location = new System.Drawing.Point(12, 25);
            this.lblStockSymbol.Name = "lblStockSymbol";
            this.lblStockSymbol.Size = new System.Drawing.Size(93, 17);
            this.lblStockSymbol.TabIndex = 7;
            this.lblStockSymbol.Text = "Stock Symbol";
            // 
            // txtRandomQuantity
            // 
            this.txtRandomQuantity.Location = new System.Drawing.Point(15, 117);
            this.txtRandomQuantity.Name = "txtRandomQuantity";
            this.txtRandomQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtRandomQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 96);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(176, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            // 
            // txtTradeQuantiy
            // 
            this.txtTradeQuantiy.Location = new System.Drawing.Point(111, 197);
            this.txtTradeQuantiy.Name = "txtTradeQuantiy";
            this.txtTradeQuantiy.Size = new System.Drawing.Size(58, 22);
            this.txtTradeQuantiy.TabIndex = 12;
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.Location = new System.Drawing.Point(179, 196);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.Size = new System.Drawing.Size(54, 22);
            this.txtTradePrice.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stock Symbol";
            // 
            // txtTradeSymbol
            // 
            this.txtTradeSymbol.Location = new System.Drawing.Point(12, 197);
            this.txtTradeSymbol.Name = "txtTradeSymbol";
            this.txtTradeSymbol.Size = new System.Drawing.Size(93, 22);
            this.txtTradeSymbol.TabIndex = 14;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(286, 177);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 41);
            this.btnBuy.TabIndex = 16;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(397, 176);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 41);
            this.btnSell.TabIndex = 17;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // formSimpleStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 426);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTradeSymbol);
            this.Controls.Add(this.txtTradePrice);
            this.Controls.Add(this.txtTradeQuantiy);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtRandomQuantity);
            this.Controls.Add(this.lblStockSymbol);
            this.Controls.Add(this.btnCalculateGBCE);
            this.Controls.Add(btnStockPrice);
            this.Controls.Add(btnTradeGen);
            this.Controls.Add(btnP_E_Rat);
            this.Controls.Add(this.btnDivYield);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOutput);
            this.Name = "formSimpleStocks";
            this.Text = "Simple Stocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDivYield;
        private System.Windows.Forms.Button btnCalculateGBCE;
        private System.Windows.Forms.Label lblStockSymbol;
        private System.Windows.Forms.TextBox txtRandomQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtTradeQuantiy;
        private System.Windows.Forms.TextBox txtTradePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeSymbol;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
    }
}

