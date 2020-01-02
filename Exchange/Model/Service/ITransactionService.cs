using System.Collections.Generic;
using Exchange.Model.Data;
using Exchange.Model.Repository;

namespace Exchange.Model.Service
{
    public interface ITransactionService
    {
        IRepository<Transaction> Repository { get; set; }
        event ServiceDelegates.UpdateTransactionsDelegate UpdateTransactionsEvent;
        Transaction PerformTransaction(Transaction transaction);

        List<Transaction> GetTransactions();
    }
}