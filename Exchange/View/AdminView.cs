using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Exchange.Model.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Exchange.View
{
    public partial class AdminView : Form, IAdminView
    {
        public BindingList<Currency> Currencies { get; set; }
        public Chart Chart { get; set; }
        public BindingList<Transaction> Transactions { get; set; }

        public event ViewDelegates.AddCurrencyDelegate AddCurrencyEvent;
        public event ViewDelegates.GetCurrenciesDelegate GetCurrenciesEvent;
        public event ViewDelegates.GetTransactionsDelegate GetTransactionsEvent;
        public event ViewDelegates.UpdateCurrencyDelegate UpdateCurrencyEvent;

        public AdminView()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddCurrencyEvent?.Invoke(
                    new Currency(
                        nameTextBoxt.Text.Length == 0 ? throw new FormatException() : nameTextBoxt.Text,
                        Double.Parse(buyRateTextBox.Text),
                        Double.Parse(sellRateTextBox.Text),
                        Double.Parse(buyLimitTextBox.Text),
                        Double.Parse(sellLimitTextBox.Text)
                    )
                );
            }
            catch (Exception exception)
            {
                ShowMessage("Failed to parse");
            }
        }

        public void UpdateCurrencies(List<Currency> currencies)
        {
            Currencies.Clear();
            currencies.ForEach(currency => { Currencies.Add(currency); });
            currenciesGrid.Update();
            currenciesGrid.Refresh();
        }

        public void UpdateTransactions(List<Transaction> transactions)
        {
            Transactions.Clear();
            transactions.ForEach(operation => Transactions.Add(operation));
            transactionsGrid.Update();
            transactionsGrid.Refresh();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            Currencies = new BindingList<Currency>();
            Transactions = new BindingList<Transaction>();
            GetCurrenciesEvent?.Invoke();
            GetTransactionsEvent?.Invoke();
            currenciesGrid.DataSource = typeof(List<Currency>);
            currenciesGrid.DataSource = Currencies;
            transactionsGrid.DataSource = typeof(List<Transaction>);
            transactionsGrid.DataSource = Transactions;
            currenciesGrid.CellValueChanged += UpdateCurrency;
        }

        private void UpdateCurrency(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCurrencyEvent?.Invoke((Currency) currenciesGrid.CurrentRow.DataBoundItem);
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            Chart = new Chart();
            Chart.Parent = chartPage;
            Chart.Dock = DockStyle.Fill;
            Chart.ChartAreas.Add(new ChartArea("Currency"));
            Series series = new Series("Money");
            series.ChartType = SeriesChartType.Bar;
            series.ChartArea = "Currency";
            var enumerable = from transaction in Transactions.ToList()
                group transaction by transaction.User;
            foreach (var grouping in enumerable)
            {
                series.Points.AddXY(grouping.Key, grouping.Sum(x => x.UserMoney));
            }
            Chart.Series.Add(series);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}