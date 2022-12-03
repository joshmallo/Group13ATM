using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System;
using System.Linq;
using Group13ATM;

class Customers
{
    private List<Customer> customerList;
    public Customers()
    {
        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        con.Open();
      

        string query = "SELECT * from Customers";
        SQLiteCommand cmd = new SQLiteCommand(query, con);

        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);
        con.Close();

        List<string>  customersData = dt.AsEnumerable().Select(x => x.ToString()).ToList();

        foreach (string customer in customersData)
        {
            List<string> list = customer.Split().ToList();
            customerList.Add(new Customer(int.Parse(list[0]), list[1], list[2], int.Parse(list[4]), list[5], int.Parse(list[6]), double.Parse(list[7]), int.Parse(list[8])));
        }
    }

    public Account FindAccount(string accountType)
    {
        return new Account();
    }

    internal List<Customer> CustomerList { get => customerList; set => customerList = value; }
}

