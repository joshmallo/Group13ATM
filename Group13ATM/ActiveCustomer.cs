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
            SetAccounts();
            return true;
        }
        else return false;
    }

    public static bool Withdraw(string accountType, double amount)
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
    public static bool Transfer(string accountFrom, string accountTo, double amount)
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

    public static void Update()
    {
        //need to update transactions and accounts

        using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
        using (SqlCommand command = con.CreateCommand())
        {
            command.CommandText = "UPDATE Accounts_@num (SET AccountNum = @bal) WHERE AccountType = current ";

            command.Parameters.AddWithValue("@num", active.AccountNumber);
            command.Parameters.AddWithValue("@bal", active.CurrentAccount.Balance);
          
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
        using (SqlCommand command = con.CreateCommand())
        {
            command.CommandText = "UPDATE Accounts_@num (SET AccountNum = @bal) WHERE AccountType = simple";

            command.Parameters.AddWithValue("@num", active.AccountNumber);
            command.Parameters.AddWithValue("@bal", active.SimpleDepositAccount.Balance);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
        using (SqlCommand command = con.CreateCommand())
        {
            command.CommandText = "UPDATE Accounts_@num (SET AccountNum = @bal) WHERE AccountType = long ";

            command.Parameters.AddWithValue("@num", active.AccountNumber);
            command.Parameters.AddWithValue("@bal", active.LongTermDepositAccount.Balance);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        
        //do transactions
    }

    static void SetAccounts()
    {
        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();


        string query = "IF EXISTS (SELECT * from Accounts_" + active.AccountNumber + " WHERE AccountType = current";
        SQLiteCommand cmd = new SQLiteCommand(query, con);

        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);

        string query1 = "SELECT * from Customers WHERE account";
        SQLiteCommand cmd1 = new SQLiteCommand(query, con);

        DataTable dt1 = new DataTable();
        SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt1);

        string query2 = "SELECT * from Customers WHERE account";
        SQLiteCommand cmd2 = new SQLiteCommand(query, con);

        DataTable dt2 = new DataTable();
        SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt2);
        con.Close();

        List<string> cAccount = dt.AsEnumerable().Select(x => x.ToString()).ToList();
        foreach (string account in cAccount)
        {
            List<string> list = account.Split().ToList();
            if (dt != null) active.CurrentAccount = new Acc(int.Parse(list[1]), int.Parse(list[2]));
        }

        List<string> sAccount = dt.AsEnumerable().Select(x => x.ToString()).ToList();
        foreach (string account in sAccount)
        {
            List<string> list = account.Split().ToList();
            if (dt != null) active.SimpleDepositAccount = new Acc(int.Parse(list[1]), int.Parse(list[2]));
        }
        List<string> lAccount = dt.AsEnumerable().Select(x => x.ToString()).ToList();
        foreach (string account in lAccount)
        {
            List<string> list = account.Split().ToList();
            if (dt != null) active.SimpleDepositAccount = new Acc(int.Parse(list[1]), int.Parse(list[2]));
        }
    }

    static void GetTransactions()
    {
        ////////
    }

    internal static Customer Active { get => active; set => active = value; }
}

