using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13ATM
{
    public class User
    {
        public CurrentAccount currentAccount { get; }
        public DepositAccount depositAccount { get; }
        public LongTermAccount longTermAccount { get; }
        public int pin { get; }

        // if user doesn't have one of the accounts, set account to null
        public User(CurrentAccount currentAccount, DepositAccount depositAccount, LongTermAccount longTermAccount, int pin)
        {
            this.currentAccount = currentAccount;
            this.depositAccount = depositAccount;
            this.longTermAccount = longTermAccount;
            this.pin = pin;
        }
    }
}
