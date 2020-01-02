using System;
using System.ComponentModel;
using Exchange.Model.Data;

namespace Exchange.View
{
    public interface ICashierView
    {
        BindingList<Currency> CashierCurrencies { get; set; }
        BindingList<Currency> UserCurrencies { get; set; }
        Transaction LastTransaction { get; set; }

        void SetMoney(Double money);

        void ShowMessage(string message);
        
        event ViewDelegates.GetCurrenciesDelegate GetCurrenciesEvent;
        event ViewDelegates.InitTransactionDelegate InitTransactionEvent;
    }
}