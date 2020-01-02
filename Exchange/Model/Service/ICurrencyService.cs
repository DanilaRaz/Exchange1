using System.Collections.Generic;
using Exchange.Model.Data;
using Exchange.Model.Repository;

namespace Exchange.Model.Service
{
    public interface ICurrencyService
    {
        IRepository<Currency> Repository { get; set; }
        List<Currency> GetCurrencies();
        event ServiceDelegates.UpdateCurrenciesDelegate UpdateCurrenciesEvent;

        void AddCurrency(Currency currency);
        void UpdateCurrency(Currency currency);
    }
}