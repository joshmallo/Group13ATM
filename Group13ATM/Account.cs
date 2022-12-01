
internal class Account
{
    private int balance;
    private bool activated;

    public Account()
    {
        this.balance = 0;
        this.activated = false;
    }
    public Account(int balance)
    {
        this.balance = balance;
        this.activated = true;
    } 

    public int Balance { get => balance; set => balance = value; }
    public bool Activated { get => activated; set => activated = value; }
}
