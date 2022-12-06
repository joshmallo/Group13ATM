using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13ATM
{
    public class Transaction
    {
        public Account account { get; }
        public string dateTime { get; }
        public double amount { get; }
        public double balanceBefore { get; }
        public double balanceAfter { get; }
        public bool success { get; }

        public Transaction(Account account, string dateTime, double amount, double balanceBefore, double balanceAfter, bool success)
        {
            this.account = account;
            this.dateTime = dateTime;
            this.amount = amount;
            this.balanceBefore = balanceBefore;
            this.balanceAfter = balanceAfter;
            this.success = success;
        }
    }
}
