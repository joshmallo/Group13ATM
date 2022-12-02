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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();
            String username, password, firstname, lastname, empID;
            username = txt_username.Text;
            password = txt_password.Text;
            firstname = txt_firstName.Text;
            lastname = txt_lastName.Text;
            empID = txt_ID.Text;

            string querry = "SELECT * from Employee";
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            con.Close();

            List<string> empIDs = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();

            foreach (string n in empIDs)
            {
                if (n != empID)
                {
                    con.Open();
                    String sqlcmd = "INSERT INTO Employee(ID, Username, Password, Firstname, Lastname) VALUES ('" + empID + "', '" + username + "', '" + password + "', '" + firstname + "', '" + lastname + "')";
                    SQLiteCommand sda = new SQLiteCommand(sqlcmd, con);
                    sda.ExecuteNonQuery();
                    MessageBox.Show("Employee account successfully created", " ", MessageBoxButtons.OK);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account number already in use", " ", MessageBoxButtons.OK);
                    txt_ID.Clear();
                    txt_ID.Focus();
                }
            }
            //con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AAS backHome = new AAS();
            backHome.Show();
            this.Hide();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();

            string querry = "SELECT * from Employee";
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            empGridView.DataSource = dt;

        }
    }
}
