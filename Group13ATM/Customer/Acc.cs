
class Acc
{
    private double balance;
    private int overdraft;
    private bool activated;

    public Acc()
    {
        this.balance = 0;
        this.activated = false;
    }
    public Acc(int balance, int overdraft)
    {
        this.balance = balance;
        this.overdraft = overdraft;
        this.activated = true;
    } 

    public double Balance { get => balance; set => balance = value; }
    public bool Activated { get => activated; set => activated = value; }
    public int Overdraft { get => overdraft; set => overdraft = value; }
}
