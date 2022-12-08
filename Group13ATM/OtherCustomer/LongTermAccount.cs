using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group13ATM
{
    public class LongTermAccount:Account
    {
        public LongTermAccount(double balance) : base(balance, "Long-term deposit") { }
    }
}
