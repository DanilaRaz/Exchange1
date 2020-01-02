using System;

namespace Exchange.Model.Data
{
    public class Transaction : Base
    {
        public TransactionClass TransactionClass { get; set; }
        public DateTime DateTime { get; set; }
        public Double UserMoney { get; set; }
        public Currency UserCurrency { get; set; }
        public Currency CashierCurrency { get; set; }
        public Double CashierMoney { get; set; }
        public string User { get; set; }
        public string Cashier { get; set; }

        public Transaction(TransactionClass transactionClass, DateTime dateTime, double userMoney,
            Currency userCurrency,
            Currency cashierCurrency, double cashierMoney, string user, string cashier)
        {
            TransactionClass = transactionClass;
            DateTime = dateTime;
            UserMoney = userMoney;
            UserCurrency = userCurrency;
            CashierCurrency = cashierCurrency;
            CashierMoney = cashierMoney;
            User = user;
            Cashier = cashier;
        }

        public override string ToString()
        {
            string transaction;
            if (TransactionClass.Equals(TransactionClass.Buy))
                transaction = $"покупке {CashierMoney} {CashierCurrency.Name} за {UserMoney} {UserCurrency}";
            else
                transaction = $"продаже {UserMoney} {UserCurrency} за {CashierMoney} {CashierCurrency.Name}";
            return $"Кассир {Cashier} {DateTime} провёл транзакцию пользователя {User} {transaction}";
        }
    }
}