using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13ATM
{
    public class DepositAccount:Account
    {
        public DepositAccount (double balance) : base(balance, "Deposit Account") { }
    }
}
