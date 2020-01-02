using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Exchange.Model.Data;

namespace Exchange.View
{
    public partial class CashierView : Form, ICashierView
    {
        public BindingList<Currency> CashierCurrencies { get; set; }
        public BindingList<Currency> UserCurrencies { get; set; }
        public Transaction LastTransaction { get; set; }

        public void SetMoney(double money)
        {
            cashierCurrencyTextBox.Text = money.ToString();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }

        public event ViewDelegates.GetCurrenciesDelegate GetCurrenciesEvent;
        public event ViewDelegates.InitTransactionDelegate InitTransactionEvent;

        public CashierView()
        {
            InitializeComponent();
        }

        private void CashierView_Load(object sender, EventArgs e)
        {
            UserCurrencies = new BindingList<Currency>();
            CashierCurrencies = new BindingList<Currency>();
            GetCurrenciesEvent?.Invoke();
            userCurrencyListBox.DataSource = UserCurrencies;
            cashierCurrencyListBox.DataSource = CashierCurrencies;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            InitTransactionEvent?.Invoke(
                CreateTransaction(TransactionClass.Buy)
            );
        }

        Transaction CreateTransaction(TransactionClass transactionClass)
        {
            try
            {
                Transaction transaction = new Transaction(
                    transactionClass,
                    DateTime.Now,
                    Double.Parse(userCurrencyTextBox.Text),
                    ((Currency) userCurrencyListBox.SelectedItem),
                    ((Currency) cashierCurrencyListBox.SelectedItem),
                    0,
                    userTextBox.Text.Length == 0 ? throw new FormatException() : userTextBox.Text,
                    cashierTextBox.Text.Length == 0 ? throw new FormatException() : cashierTextBox.Text
                );
                return transaction;
            }
            catch (Exception e)
            {
                ShowMessage("Failed to parse");
            }

            return null;
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            InitTransactionEvent?.Invoke(
                CreateTransaction(TransactionClass.Sell)
            );
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(LastTransaction);
                }
            }
        }
    }
}