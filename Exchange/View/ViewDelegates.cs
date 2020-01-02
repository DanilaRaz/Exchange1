using Exchange.Model.Data;

namespace Exchange.View
{
    public class ViewDelegates
    {
        public delegate void GetCurrenciesDelegate();
        public delegate void InitTransactionDelegate(Transaction transaction);
        public delegate void AddCurrencyDelegate(Currency currency);
        public delegate void GetTransactionsDelegate();
        public delegate void UpdateCurrencyDelegate(Currency currency);
        
    }
}