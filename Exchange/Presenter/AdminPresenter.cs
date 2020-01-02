using Exchange.Model.Data;
using Exchange.Model.Service;
using Exchange.View;

namespace Exchange.Presenter
{
    public class AdminPresenter:IAdminPresenter
    {
        private IAdminView AdminView;
        private ICurrencyService CurrencyService;
        private ITransactionService TransactionService;

        public AdminPresenter(IAdminView adminView, ICurrencyService currencyService, ITransactionService transactionService)
        {
            AdminView = adminView;
            CurrencyService = currencyService;
            TransactionService = transactionService;

            AdminView.AddCurrencyEvent += AddCurrency;
            AdminView.GetCurrenciesEvent += UpdateCurrencies;
            AdminView.GetTransactionsEvent += UpdateTransactions;
            AdminView.UpdateCurrencyEvent += UpdateCurrency;
            TransactionService.UpdateTransactionsEvent += UpdateTransactions;
        }

        private void UpdateCurrency(Currency currency)
        {
            CurrencyService.UpdateCurrency(currency);
        }

        private void UpdateTransactions()
        {
            AdminView.UpdateTransactions(TransactionService.GetTransactions());
        }

        private void UpdateCurrencies()
        {
            AdminView.UpdateCurrencies(CurrencyService.GetCurrencies());
        }

        private void AddCurrency(Currency currency)
        {
            CurrencyService.AddCurrency(currency);
            UpdateCurrencies();
        }
    }
}