using System.Data.SQLite;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Group13ATM;
using System.Linq;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

static class ActiveCustomer
{
    static Customer active;
    static Customers customers;

    static bool CheckAccountNumber(int accNum)
    {
        if (customers.CustomerList.Any(x => x.AccountNumber == accNum))
        {
            active = customers.CustomerList.FirstOrDefault(x => x.AccountNumber == accNum);
            active.CurrentAccount         = customers.FindAccount("c");
            active.SimpleDepositAccount   = customers.FindAccount("s");
            active.LongTermDepositAccount = customers.FindAccount("l");
            return true;
        }
        else return false;
    }

    static bool Withdraw(string accountType, double amount)
    {
        if (accountType == "simple")
        {
            if (active.SimpleDepositAccount.Balance - amount < 0)
            {
                active.Transactions.Add(new Transaction(accountType, DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", active.CurrentAccount.Balance, true));
                return false;
            }
            else return true;
        }
        else
        {
            if (active.CurrentAccount.Balance - amount < 0 - active.Overdraft)
            {
                active.Transactions.Add(new Transaction(accountType, DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", active.CurrentAccount.Balance, false));
                return false;
            }
            else
            { 
                active.CurrentAccount.Balance-= amount;
                active.Transactions.Add(new Transaction(accountType, DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", active.CurrentAccount.Balance, true));
                return true; 
            }
        }
        }
    static bool Transfer(string accountFrom, string accountTo, double amount)
    {
        if(accountFrom == "simple")
        {
            if(accountTo == "current" && active.SimpleDepositAccount.Balance - amount >= 0)
            {
                active.SimpleDepositAccount.Balance -= amount;
                active.CurrentAccount.Balance += amount;
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.SimpleDepositAccount.Balance, true));
                active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.CurrentAccount.Balance, true));
                return true;
            }
            else if(active.LongTermDepositAccount.Balance - amount >= 0)
            {
                active.LongTermDepositAccount.Balance -= amount;
                active.CurrentAccount.Balance += amount;
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.SimpleDepositAccount.Balance, true));
                active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.LongTermDepositAccount.Balance, true));
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.SimpleDepositAccount.Balance, false));
                if(accountTo == "current") active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.CurrentAccount.Balance, false));
                else active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.CurrentAccount.Balance, false));
                return false;
            }
        }
        else
        {
            if(accountTo == "simple" && active.CurrentAccount.Balance - amount <= 0 - active.Overdraft)
            {
                active.CurrentAccount.Balance -= amount;
                active.SimpleDepositAccount.Balance += amount;
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.CurrentAccount.Balance, true));
                active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.SimpleDepositAccount.Balance, true));
                return true;
            }
            else if(active.CurrentAccount.Balance - amount <= 0 - active.Overdraft)
            {
                active.CurrentAccount.Balance -= amount;
                active.SimpleDepositAccount.Balance += amount;
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.CurrentAccount.Balance, true));
                active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.LongTermDepositAccount.Balance, true));
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction(accountFrom, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", active.CurrentAccount.Balance, false));
                if (accountTo == "simple") active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.SimpleDepositAccount.Balance, false));
                else active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.LongTermDepositAccount.Balance, false));
                return false;
            }
        }
    }

    static void Update()
    {

        using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
        using (SqlCommand command = con.CreateCommand())
        {
            command.CommandText = "UPDATE Customer SET AccounNum = @an, Firstname = @fn" +
                " Lastname = @ln PIN = @p Address = @add Age = @a Salary = @as Overdraft = @o) ";


            command.Parameters.AddWithValue("@an", active.AccountNumber);
            command.Parameters.AddWithValue("@fn", active.FirstName);
            command.Parameters.AddWithValue("@ln", active.LastName);
            command.Parameters.AddWithValue("@p", active.Pin);
            command.Parameters.AddWithValue("@add", active.Address);
            command.Parameters.AddWithValue("@a", active.Age);
            command.Parameters.AddWithValue("@as", active.AnnualSalary);
            command.Parameters.AddWithValue("@o", active.Overdraft);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        List<string> accountTypes = new List<string>()
        {
            "CurrentAccount",
            "SimpleDepositAccount",
            "LongTermDeposit"
        };
        foreach (string accountType in accountTypes)
        {
            using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "UPDATE @at SET Balance = @b, Activated = @a";

                command.Parameters.AddWithValue("@at", accountType);
                if (accountType == "CurrentAccount")
                {
                    command.Parameters.AddWithValue("@b", active.CurrentAccount.Balance);
                    command.Parameters.AddWithValue("@a", active.CurrentAccount.Activated);
                }
                else if (accountType == "SimpleDepositAccount")
                {
                    command.Parameters.AddWithValue("@b", active.SimpleDepositAccount.Balance);
                    command.Parameters.AddWithValue("@a", active.SimpleDepositAccount.Activated);
                }
                else
                {
                    command.Parameters.AddWithValue("@b", active.LongTermDepositAccount.Balance);
                    command.Parameters.AddWithValue("@a", active.LongTermDepositAccount.Activated);
                }
                

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    internal static Customer Active { get => active; set => active = value; }
}

