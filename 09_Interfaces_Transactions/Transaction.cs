
using _09_Interfaces_Transactions.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Transactions
{
    public class Transaction
    {
        //Dependancy Injection
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;

            DateOfTransaction = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset DateOfTransaction { get; }

        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType()
        {
            return _currency.Name;
        }
    }
}
