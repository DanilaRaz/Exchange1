using System.ComponentModel;

namespace Exchange.View
{
    partial class AdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.currenciesGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.chartButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sellLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buyLimitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellRateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buyRateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBoxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCurrencyButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.chartPage.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.chartPage);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.currenciesGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Currencies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // currenciesGrid
            // 
            this.currenciesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currenciesGrid.Location = new System.Drawing.Point(0, 0);
            this.currenciesGrid.Name = "currenciesGrid";
            this.currenciesGrid.RowHeadersWidth = 51;
            this.currenciesGrid.Size = new System.Drawing.Size(1057, 525);
            this.currenciesGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.transactionsGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Location = new System.Drawing.Point(0, 0);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.RowHeadersWidth = 51;
            this.transactionsGrid.Size = new System.Drawing.Size(1057, 525);
            this.transactionsGrid.TabIndex = 1;
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.chartButton);
            this.chartPage.Location = new System.Drawing.Point(4, 25);
            this.chartPage.Name = "chartPage";
            this.chartPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartPage.Size = new System.Drawing.Size(1058, 525);
            this.chartPage.TabIndex = 2;
            this.chartPage.Text = "Graphics";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(486, 503);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(577, 25);
            this.chartButton.TabIndex = 0;
            this.chartButton.Text = "chart";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sellLimitTextBox);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.buyLimitTextBox);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.sellRateTextBox);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.buyRateTextBox);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.nameTextBoxt);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.addCurrencyButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1058, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "AddCurrency";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // sellLimitTextBox
            // 
            this.sellLimitTextBox.Location = new System.Drawing.Point(555, 162);
            this.sellLimitTextBox.Name = "sellLimitTextBox";
            this.sellLimitTextBox.Size = new System.Drawing.Size(172, 22);
            this.sellLimitTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(434, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sell Limit";
            // 
            // buyLimitTextBox
            // 
            this.buyLimitTextBox.Location = new System.Drawing.Point(555, 131);
            this.buyLimitTextBox.Name = "buyLimitTextBox";
            this.buyLimitTextBox.Size = new System.Drawing.Size(172, 22);
            this.buyLimitTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(434, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buy Limit";
            // 
            // sellRateTextBox
            // 
            this.sellRateTextBox.Location = new System.Drawing.Point(555, 99);
            this.sellRateTextBox.Name = "sellRateTextBox";
            this.sellRateTextBox.Size = new System.Drawing.Size(172, 22);
            this.sellRateTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(434, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sell Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buyRateTextBox
            // 
            this.buyRateTextBox.Location = new System.Drawing.Point(555, 69);
            this.buyRateTextBox.Name = "buyRateTextBox";
            this.buyRateTextBox.Size = new System.Drawing.Size(172, 22);
            this.buyRateTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(434, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buy Rate";
            // 
            // nameTextBoxt
            // 
            this.nameTextBoxt.Location = new System.Drawing.Point(555, 38);
            this.nameTextBoxt.Name = "nameTextBoxt";
            this.nameTextBoxt.Size = new System.Drawing.Size(172, 22);
            this.nameTextBoxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(434, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // addCurrencyButton
            // 
            this.addCurrencyButton.Location = new System.Drawing.Point(531, 193);
            this.addCurrencyButton.Name = "addCurrencyButton";
            this.addCurrencyButton.Size = new System.Drawing.Size(86, 25);
            this.addCurrencyButton.TabIndex = 0;
            this.addCurrencyButton.Text = "addCurrency";
            this.addCurrencyButton.UseVisualStyleBackColor = true;
            this.addCurrencyButton.Click += new System.EventHandler(this.addCurrencyButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currenciesGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.chartPage.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buyLimitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sellLimitTextBox;
        private System.Windows.Forms.Button addCurrencyButton;
        private System.Windows.Forms.TextBox nameTextBoxt;
        private System.Windows.Forms.TextBox buyRateTextBox;
        private System.Windows.Forms.TextBox sellRateTextBox;
        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.DataGridView currenciesGrid;
        private System.Windows.Forms.TabPage chartPage;
        private System.Windows.Forms.Button chartButton;
    }
}