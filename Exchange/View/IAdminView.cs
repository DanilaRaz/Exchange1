using System.Collections.Generic;
using System.ComponentModel;
using Exchange.Model.Data;

namespace Exchange.View
{
    public interface IAdminView
    {
        BindingList<Currency> Currencies { get; set; }
        BindingList<Transaction> Transactions { get; set; }

        event ViewDelegates.AddCurrencyDelegate AddCurrencyEvent;
        event ViewDelegates.GetCurrenciesDelegate GetCurrenciesEvent;
        event ViewDelegates.GetTransactionsDelegate GetTransactionsEvent;
        event ViewDelegates.UpdateCurrencyDelegate UpdateCurrencyEvent;

        void UpdateCurrencies(List<Currency> currencies);
        void UpdateTransactions(List<Transaction> transactions);
    }
}