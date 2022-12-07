using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Group13ATM
{
    public static class Server
    {

        public static SQLiteConnection Connect() 
        {
            return new SQLiteConnection(Functions.pathToDB());
        }
        public static bool WithdrawCash(string accountType, double amount)
        {
            // when cash is withdrawn
            return ActiveCustomer.Withdraw(accountType, amount);
        }

        public static bool Transfer(string transferFrom, string transferTo, double amount)
        {
            // transfer between accounts
            return ActiveCustomer.Transfer(transferFrom, transferTo, amount);
        }

        public static User FetchUser(int number)
        {
            Customers customers = new Customers();
            Customer customer = customers.CustomerList.FirstOrDefault(x=>x.AccountNumber == number);
            return new User(new CurrentAccount(customer.CurrentAccount.Balance), new DepositAccount(customer.SimpleDepositAccount.Balance), new LongTermAccount(customer.LongTermDepositAccount.Balance), customer.Pin);
        }
        public static void Withdraw(string accountType, double amount)
        {
            ActiveCustomer.Withdraw(accountType, amount);
        }
        
        public static void Save() 
        {
            ActiveCustomer.Update();
        }
    }
}
