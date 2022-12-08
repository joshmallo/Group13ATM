using Group13ATM;

using System.Collections.Generic;

class Customer
{
    private Acc currentAccount; 
    private Acc simpleDepositAccount;
    private Acc longTermDepositAccount;
    private string firstName;
    private string lastName;
    private string address;
    private double annualSalary;
    private int age;
    private int accountNumber;
    private int pin;
    private bool cardUsable;
    private List<Transaction> transactions;

    public Customer(int accountNumber, string firstName, string lastName, int pin, string address, int age, double annualSalary, bool cardUsable)
    {
        this.accountNumber     = accountNumber;
        this.FirstName         = firstName;
        this.LastName          = lastName;
        this.Age               = age;
        this.Address           = address;
        this.AnnualSalary      = annualSalary;
        this.pin = pin;
        this.CardUsable = cardUsable;
        CurrentAccount         = new Acc();
        SimpleDepositAccount   = new Acc();
        LongTermDepositAccount = new Acc();
    }


    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Address { get => address; set => address = value; }
    public double AnnualSalary { get => annualSalary; set => annualSalary = value; }
    public int Age { get => age; set => age = value; }
    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public int Pin { get => pin; set => pin = value; }
    public bool CardUsable { get => cardUsable; set => cardUsable = value; }
    internal List<Transaction> Transactions { get => transactions; set => transactions = value; }
    internal Acc CurrentAccount { get => currentAccount; set => currentAccount = value; }
    internal Acc SimpleDepositAccount { get => simpleDepositAccount; set => simpleDepositAccount = value; }
    internal Acc LongTermDepositAccount { get => longTermDepositAccount; set => longTermDepositAccount = value; }
}
