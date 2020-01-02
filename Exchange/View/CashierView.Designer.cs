using System.ComponentModel;

namespace Exchange.View
{
    partial class CashierView
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
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierTextBox = new System.Windows.Forms.TextBox();
            this.cashierCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.userCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userCurrencyListBox = new System.Windows.Forms.ListBox();
            this.cashierCurrencyListBox = new System.Windows.Forms.ListBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(428, 76);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(174, 23);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.Text = "Rozanov Danik";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(388, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(376, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cashier";
            // 
            // cashierTextBox
            // 
            this.cashierTextBox.Location = new System.Drawing.Point(428, 105);
            this.cashierTextBox.Name = "cashierTextBox";
            this.cashierTextBox.Size = new System.Drawing.Size(174, 23);
            this.cashierTextBox.TabIndex = 2;
            this.cashierTextBox.Text = "Кизим Степан Александрович";
            // 
            // cashierCurrencyTextBox
            // 
            this.cashierCurrencyTextBox.Location = new System.Drawing.Point(428, 163);
            this.cashierCurrencyTextBox.Name = "cashierCurrencyTextBox";
            this.cashierCurrencyTextBox.Size = new System.Drawing.Size(100, 23);
            this.cashierCurrencyTextBox.TabIndex = 6;
            // 
            // userCurrencyTextBox
            // 
            this.userCurrencyTextBox.Location = new System.Drawing.Point(428, 134);
            this.userCurrencyTextBox.Name = "userCurrencyTextBox";
            this.userCurrencyTextBox.Size = new System.Drawing.Size(100, 23);
            this.userCurrencyTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserCurrency";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(328, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CashierCurrency";
            // 
            // userCurrencyListBox
            // 
            this.userCurrencyListBox.FormattingEnabled = true;
            this.userCurrencyListBox.ItemHeight = 15;
            this.userCurrencyListBox.Location = new System.Drawing.Point(534, 135);
            this.userCurrencyListBox.Name = "userCurrencyListBox";
            this.userCurrencyListBox.Size = new System.Drawing.Size(377, 19);
            this.userCurrencyListBox.TabIndex = 9;
            // 
            // cashierCurrencyListBox
            // 
            this.cashierCurrencyListBox.FormattingEnabled = true;
            this.cashierCurrencyListBox.ItemHeight = 15;
            this.cashierCurrencyListBox.Location = new System.Drawing.Point(534, 166);
            this.cashierCurrencyListBox.Name = "cashierCurrencyListBox";
            this.cashierCurrencyListBox.Size = new System.Drawing.Size(377, 19);
            this.cashierCurrencyListBox.TabIndex = 10;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(437, 192);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 11;
            this.buyButton.Text = "buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(437, 222);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 12;
            this.sellButton.Text = "sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(437, 250);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(75, 23);
            this.billButton.TabIndex = 13;
            this.billButton.Text = "bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // CashierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.cashierCurrencyListBox);
            this.Controls.Add(this.userCurrencyListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cashierCurrencyTextBox);
            this.Controls.Add(this.userCurrencyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashierTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTextBox);
            this.Name = "CashierView";
            this.Text = "CashierView";
            this.Load += new System.EventHandler(this.CashierView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox cashierTextBox;
        private System.Windows.Forms.TextBox userCurrencyTextBox;
        private System.Windows.Forms.TextBox cashierCurrencyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox cashierCurrencyListBox;
        private System.Windows.Forms.ListBox userCurrencyListBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Button buyButton;
    }
}