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
            customerList.Add(new Customer(Convert.ToInt32(list[0]), list[1], list[2], Convert.ToInt32(list[3]), list[4], Convert.ToInt32(list[5]), Convert.ToDouble(list[6]), Convert.ToBoolean(list[7])));
        }
    }

    


    internal List<Customer> CustomerList { get => customerList; set => customerList = value; }
}

