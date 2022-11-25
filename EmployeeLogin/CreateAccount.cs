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
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\USER\Desktop\Year2SHU\IntroToSoft\Project\Group13ATM\Databases\Employee.db");
            con.Open();
            String username, password, firstname, lastname, empID;
            username = txt_username.Text;
            password = txt_password.Text;
            firstname = txt_firstName.Text;
            lastname = txt_lastName.Text;
            empID = txt_ID.Text;

            // create another try catch to check an existing employee ID
            // if true, return error message
            // else, implement the try catch to insert the data

            try
            {
                String querry = "INSERT INTO Employee(ID, Username, Password, Firstname, Lastname) VALUES ('"+empID+"', '"+username+"', '"+password+"', '"+firstname+"', '"+lastname+"')";
                SQLiteCommand sda = new SQLiteCommand(querry, con);
                sda.ExecuteNonQuery();
                MessageBox.Show("entered..."," ", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("error!");
            }
            finally
            {
                con.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AAS backHome = new AAS();
            backHome.Show();
            this.Hide();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\USER\Desktop\Year2SHU\IntroToSoft\Project\Group13ATM\Databases\Employee.db");
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
