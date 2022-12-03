 class Transaction
{
    private string accountType;
    private string date;
    private double amount;
    private string type;
    private double balance;
    private bool success;

    public Transaction(string accountType, string date, double amount, string type, double balance, bool success)
    {
        this.accountType = accountType;
        this.date = date;
        this.amount = amount;
        this.type = type;
        this.balance = balance;
        this.success = success;
    }
}

