

class Customer
{
    private Account currentAccount;
    private Account simpleDepositAccount;
    private Account longTermDepositAccount;
    private string name;
    private string address;
    private double annualSalary;
    private int age;
    private int iD;
    private int pin;
    private bool special;

    public Customer(string name, int age, string address, double annualSalary, int iD)
    {
        this.name = name;
        this.age = age;
        this.address = address;
        this.annualSalary = annualSalary;
        currentAccount = new Account();
        simpleDepositAccount = new Account();
        longTermDepositAccount = new Account();
        iD = iD;
    }
}
