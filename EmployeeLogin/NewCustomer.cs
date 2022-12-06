using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EmployeeLogin
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            AAS back = new AAS();
            back.Show();
            this.Hide();
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();

            string querry = "SELECT * from Customer";
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            customerDataView.DataSource = dt;
            con.Close();
        }
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();
            String accountNum, firstname, lastname, pin, age, address, salary, overdraft;
            accountNum = txt_accountNumber.Text;
            firstname = txt_firstName.Text;
            lastname = txt_lastName.Text;
            pin = txt_PIN.Text;
            age = txt_age.Text;
            address = txt_address.Text;
            salary = txt_salary.Text;
            overdraft = txt_overdraft.Text;

            string querry = "SELECT * from Customer";
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();

            List<string> accountNumbers = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();

            foreach (string n in accountNumbers)
            {
                if(n != accountNum)
                {
                    con.Open();
                    String sqlcmd = "INSERT INTO Customer(AccountNum, Firstname, Lastname, PIN, Age, Address, Salary, Overdraft) VALUES ('" +Convert.ToInt32(accountNum)+ "', '" +firstname+ "', '" +lastname+ "', '" +Convert.ToInt32(pin)+ "', '" + Convert.ToInt32(age) + "', '" +address+ "', '" +Convert.ToInt32(salary)+ "', '"+Convert.ToInt32(overdraft)+"')";
                    SQLiteCommand sda = new SQLiteCommand(sqlcmd, con);
                    sda.ExecuteNonQuery();
                    MessageBox.Show("Account successfully created!", " ", MessageBoxButtons.OK);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account number already in use", " ", MessageBoxButtons.OK);
                    txt_accountNumber.Clear();
                }
            }
        }
    }
}
