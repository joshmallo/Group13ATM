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
            GetAccounts();
            GetTransactions();
            return true;
        }
        else return false;
    }

    public static bool Withdraw(string accountType, double amount)
    {
        if (accountType == "simple")
        {
            if (active.SimpleDepositAccount.Balance - amount >= 0)
            {
                active.SimpleDepositAccount.Balance -= amount;
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", true, accountType, active.SimpleDepositAccount.Balance));
                Update();
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", false, accountType, active.SimpleDepositAccount.Balance));
                Update();
                return true;
            }
        }
        else
        {
            if (active.CurrentAccount.Balance - amount >= 0 - active.CurrentAccount.Overdraft)
            {
                active.CurrentAccount.Balance -= amount;
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", true, accountType, active.SimpleDepositAccount.Balance));
                Update();
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "withdraw", false, accountType, active.SimpleDepositAccount.Balance));
                Update();
                return false;
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
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", true, accountFrom, active.SimpleDepositAccount.Balance));
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", true, accountTo, active.CurrentAccount.Balance));
                Update();
                return true;
            }
            else if(active.LongTermDepositAccount.Balance - amount >= 0)
            {
                active.LongTermDepositAccount.Balance -= amount;
                active.CurrentAccount.Balance += amount;
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", true, accountFrom, active.SimpleDepositAccount.Balance));
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", true, accountTo, active.LongTermDepositAccount.Balance));
                Update();
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", true, accountFrom, active.SimpleDepositAccount.Balance));
                /*if (accountTo == "current") active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.CurrentAccount.Balance, false));
                else active.Transactions.Add(new Transaction(accountTo, DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", active.CurrentAccount.Balance, false));*/
                Update();
                return false;
            }
        }
        else
        {
            if(accountTo == "simple" && active.CurrentAccount.Balance - amount >= 0 - active.CurrentAccount.Overdraft)
            {
                active.CurrentAccount.Balance -= amount;
                active.SimpleDepositAccount.Balance += amount;
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", true, accountFrom, active.CurrentAccount.Balance));
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", true, accountTo, active.SimpleDepositAccount.Balance));
                Update();
                return true;
            }
            else if(active.CurrentAccount.Balance - amount >= 0 - active.CurrentAccount.Overdraft)
            {
                active.CurrentAccount.Balance -= amount;
                active.LongTermDepositAccount.Balance += amount;
                active.Transactions.Add(new Transaction("save",DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", true, accountFrom, active.CurrentAccount.Balance));
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", true, accountTo, active.LongTermDepositAccount.Balance));
                Update();
                return true;
            }
            else
            {
                active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-out", false, accountFrom, active.CurrentAccount.Balance));
                /* if (accountTo == "simple") active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", false, accountTo, active.LongTermDepositAccount.Balance));
                 else active.Transactions.Add(new Transaction("save", DateTime.Today.ToString("dd/MM/yy"), amount, "transfer-in", false, accountTo, active.LongTermDepositAccount.Balance));*/
                Update();
                return false;
            }
          
        }
    }

    public static void Update()
    {


        //todo
        Dictionary<string, double> accs = new Dictionary<string, double>()
        {
            {"current", active.CurrentAccount.Balance },
            {"simple", active.SimpleDepositAccount.Balance },
            {"long", active.LongTermDepositAccount.Balance }
        };
        foreach (KeyValuePair<string, double> kvp in accs)
        {
            using (SqlConnection con = new SqlConnection(Functions.pathToDB()))
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "UPDATE Accounts_@num (SET AccountNum = @bal) WHERE AccountType = @acc ";

                command.Parameters.AddWithValue("@num", active.AccountNumber);
                command.Parameters.AddWithValue("@bal", kvp.Value);
                command.Parameters.AddWithValue("@acc", kvp.Key);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

        }
    }

    static void GetAccounts()
    {
        //todo

        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();


        string query = "SELECT * from Accounts_" + active.AccountNumber;
        SQLiteCommand cmd = new SQLiteCommand(query, con);

        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);
        con.Close();

        List<string> accountData = dt.AsEnumerable().Select(x => x.ToString()).ToList();

        foreach (string account in accountData)
        {
            List<string> list = account.Split().ToList();
            if (list[0] == "current") active.CurrentAccount = new Acc(Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), Convert.ToBoolean(list[3]));
            else if (list[0] == "simple") active.SimpleDepositAccount = new Acc(Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), Convert.ToBoolean(list[3]));
            else active.LongTermDepositAccount = new Acc(Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), Convert.ToBoolean(list[3]));

        }

    }

    static void GetTransactions()
    {
        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();


        string query = "IF EXISTS (SELECT * from Transactions_" + active.AccountNumber + ")";
        SQLiteCommand cmd = new SQLiteCommand(query, con);

        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);

        List<string> transactionData = dt.AsEnumerable().Select(x => x.ToString()).ToList();
        if (dt != null)
        {
            foreach (string transaction in transactionData)
            {
                List<string> list = transaction.Split().ToList();
                active.Transactions.Add(new Transaction(list[0], list[1], Convert.ToDouble(list[2]), list[3], Convert.ToBoolean(list[4]), list[5], Convert.ToDouble(list[6])));
            }////////////////////todo
        }
        else active.Transactions = new List<Transaction>();
    }

    public static void SetUnUsable()
    {
        active.CardUsable = false;

        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();


        string query = "UPDATE Customer (SET CardUsable = false )WHERE AccountNum =" + active.AccountNumber;
        SQLiteCommand cmd = new SQLiteCommand(query, con);

        cmd.ExecuteNonQuery();

        con.Close();

    }

    internal static Customer Active { get => active; set => active = value; }
}

