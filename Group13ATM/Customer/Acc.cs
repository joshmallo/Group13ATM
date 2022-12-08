
class Acc
{
    private double balance;
    private int overdraft;
    private bool active;

    public Acc()
    {
        this.balance = 0;
        this.active = false;
    }
    public Acc(int balance, int overdraft, bool active)
    {
        this.balance = balance;
        this.overdraft = overdraft;
    } 

    public double Balance { get => balance; set => balance = value; }
    public bool Active { get => active; set => active = value; }
    public int Overdraft { get => overdraft; set => overdraft = value; }
}
