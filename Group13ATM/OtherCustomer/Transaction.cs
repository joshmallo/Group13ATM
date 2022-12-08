using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public Transaction(string save, Account account, string dateTime, double amount, double balanceBefore, double balanceAfter, bool success)
        {
            this.account = account;
            this.dateTime = dateTime;
            this.amount = amount;
            this.balanceBefore = balanceBefore;
            this.balanceAfter = balanceAfter;
            this.success = success;

            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();
            String sqlcmd = "INSERT INTO Transaction_" + ActiveCustomer.Active.AccountNumber + "(AccountNum, Firstname, Lastname, PIN, Age, Address, Salary, Overdraft) VALUES ('" + accountNum + "', '" + firstname + "', '" + lastname + "', '" + pin + "', '" + age + "', '" + address + "', '" + salary + "', '" + overdraft + "')";
            SQLiteCommand sda = new SQLiteCommand(sqlcmd, con);
            
            sda.ExecuteNonQuery();
            
           
            con.Close();
        }
    }
}
