using Group13ATM;
using System.Data.SQLite;

class Transaction
{
    private string accountType;
    private string date;
    private double amount;
    private string type;
    private double balance;
    private bool success;

    public Transaction(string date, double amount, string type, bool success, string accountType, double balance)
    {
        this.accountType = accountType;
        this.date = date;
        this.amount = amount;
        this.type = type;
        this.balance = balance;
        this.success = success;
    }
    public Transaction(string save, string date, double amount, string type, bool success, string accountType, double balance)
    {
        this.accountType = accountType;
        this.date = date;
        this.amount = amount;
        this.type = type;
        this.balance = balance;
        this.success = success;

        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();
        string sqlcmd = "INSERT INTO Transactions_" + ActiveCustomer.Active.AccountNumber + "(Date, Transaction, TransactionType,Sucess, AccountType, Balance) VALUES ('" + date + "', '" + amount + "', '" + type + "', '" + success + "', '" + accountType + "', '" + balance + "')";
        SQLiteCommand sda = new SQLiteCommand(sqlcmd, con);
        sda.ExecuteNonQuery();
        con.Close();
    }
}

