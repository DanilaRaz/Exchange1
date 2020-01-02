using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Exchange.Model.Data;
using Exchange.Model.Repository;

namespace Exchange.Model.Service
{
    public class TransactionService : ITransactionService
    {
        public IRepository<Transaction> Repository { get; set; }
        public event ServiceDelegates.UpdateTransactionsDelegate UpdateTransactionsEvent;

        public TransactionService(IRepository<Transaction> repository)
        {
            Repository = repository;
        }

        public Transaction PerformTransaction(Transaction transaction)
        {
            Double cashierMoney = CalculateAmount(transaction);
            transaction.CashierMoney = cashierMoney;
            if (CheckLimit(transaction))
                throw new EvaluateException();
            Repository.Add(transaction);
            UpdateTransactionsEvent?.Invoke();
            return transaction;
        }

        public List<Transaction> GetTransactions()
        {
            return Repository.GetAll();
        }

        private bool CheckLimit(Transaction currentTransaction)
        {
            List<Transaction> transactions = Repository.FindBy(transaction =>
                transaction.DateTime.Day.Equals(currentTransaction.DateTime.Day) &&
                transaction.User.Equals(currentTransaction.User) &&
                transaction.CashierCurrency.Name.Equals(currentTransaction.CashierCurrency.Name) &&
                transaction.TransactionClass.Equals(currentTransaction.TransactionClass));
            if (transactions.Count == 0)
                return false;
            Double totalUserMoney =
                transactions.Select(transaction => transaction.CashierMoney).Aggregate((a, b) => a + b) +
                currentTransaction.CashierMoney;
            if (currentTransaction.TransactionClass == TransactionClass.Buy)
                return totalUserMoney > currentTransaction.CashierCurrency.BuyRate;
            return totalUserMoney > currentTransaction.CashierCurrency.SellRate;
        }

        private double CalculateAmount(Transaction transaction)
        {
            if (transaction.CashierCurrency.Equals(transaction.UserCurrency))
                return transaction.UserMoney;
            if (transaction.TransactionClass == TransactionClass.Buy)
                return transaction.UserMoney / transaction.CashierCurrency.BuyRate * transaction.UserCurrency.SellRate;
            return transaction.UserMoney / transaction.CashierCurrency.SellRate * transaction.UserCurrency.BuyRate;
        }
    }
}