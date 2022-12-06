using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13ATM
{
    public class Account
    {
        public double balance { get; }
        public List<Transaction> transactions;
        public string type { get; }
        public Account(double balance, string type)
        {
            this.balance = balance;
            transactions = new List<Transaction>();
            this.type = type;
        }

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}
