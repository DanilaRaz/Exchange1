using System.Collections.Generic;
using Exchange.Model.Data;
using Exchange.Model.Repository;

namespace Exchange.Model.Service
{
    public class CurrencyService : ICurrencyService
    {
        public IRepository<Currency> Repository { get; set; }
        public event ServiceDelegates.UpdateCurrenciesDelegate UpdateCurrenciesEvent;

        public CurrencyService(IRepository<Currency> repository)
        {
            Repository = repository;
            Repository.Add(new Currency("USD", 10,15,12312,121222));
            Repository.Add(new Currency("EUR", 20,5,122,1222));
            Repository.Add(new Currency("ADN", 30,151,1312,12122));
        }

        public List<Currency> GetCurrencies()
        {
            return Repository.GetAll();
        }

        public void AddCurrency(Currency currency)
        {
            Repository.Add(currency);
            UpdateCurrenciesEvent?.Invoke();
        }

        public void UpdateCurrency(Currency currency)
        {
            Repository.Update(currency);
            UpdateCurrenciesEvent?.Invoke();
        }
    }
}