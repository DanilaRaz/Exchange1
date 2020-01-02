using System.Collections.Generic;
using System.Data;
using Exchange.Model.Data;
using Exchange.Model.Service;
using Exchange.View;

namespace Exchange.Presenter
{
    public class CashierPresenter: ICashierPresenter
    {
        private ICashierView CashierView;
        private ICurrencyService CurrencyService;
        private ITransactionService TransactionService;

        public CashierPresenter(ICashierView cashierView, ICurrencyService currencyService, ITransactionService transactionService)
        {
            CashierView = cashierView;
            CurrencyService = currencyService;
            TransactionService = transactionService;
            
            CashierView.GetCurrenciesEvent += SetCurrencies;
            CashierView.InitTransactionEvent += PerformTransaction;
            CurrencyService.UpdateCurrenciesEvent += SetCurrencies;
        }

        private void PerformTransaction(Transaction transaction)
        {
            try
            {
                Transaction performTransaction = TransactionService.PerformTransaction(transaction);
                CashierView.LastTransaction = performTransaction;
                CashierView.SetMoney(performTransaction.CashierMoney);
            }
            catch (EvaluateException e)
            {
                CashierView.ShowMessage("Limit reached");
            }
        }

        private void SetCurrencies()
        {
            List<Currency> currencies = CurrencyService.GetCurrencies();
            CashierView.UserCurrencies.Clear();
            currencies.ForEach(currency => CashierView.UserCurrencies.Add(currency));
            CashierView.CashierCurrencies.Clear();
            currencies.ForEach(currency => CashierView.CashierCurrencies.Add(currency));
        }
    }
}