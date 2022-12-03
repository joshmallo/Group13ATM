

using System.Collections.Generic;

class Customer
{
    private Account currentAccount;
    private Account simpleDepositAccount;
    private Account longTermDepositAccount;
    private string firstName;
    private string lastName;
    private string address;
    private double annualSalary;
    private int age;
    private int accountNumber;
    private int pin;
    private int overdraft;
    private List<Transaction> transactions;

    public Customer(int accountNumber, string firstName, string lastName, int pin, string address, int age, double annualSalary, int overdraft = 0)
    {
        this.accountNumber     = accountNumber;
        this.FirstName         = firstName;
        this.LastName          = lastName;
        this.Age               = age;
        this.Address           = address;
        this.AnnualSalary      = annualSalary;
        this.Overdraft         = overdraft;
        CurrentAccount         = new Account();
        SimpleDepositAccount   = new Account();
        LongTermDepositAccount = new Account();
    }


    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Address { get => address; set => address = value; }
    public double AnnualSalary { get => annualSalary; set => annualSalary = value; }
    public int Age { get => age; set => age = value; }
    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public int Pin { get => pin; set => pin = value; }
    public int Overdraft { get => overdraft; set => overdraft = value; }
    internal Account CurrentAccount { get => currentAccount; set => currentAccount = value; }
    internal Account SimpleDepositAccount { get => simpleDepositAccount; set => simpleDepositAccount = value; }
    internal Account LongTermDepositAccount { get => longTermDepositAccount; set => longTermDepositAccount = value; }
    internal List<Transaction> Transactions { get => transactions; set => transactions = value; }
}
