using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EmployeeLogin
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password, firstname, lastname, empID;
            username = txt_username.Text;
            password = txt_password.Text;
            firstname = txt_firstName.Text;
            lastname = txt_lastName.Text;
            empID = ID.Text;

            // create another try catch to check an existing employee ID
            // if true, return error message
            // else, implement the try catch to insert the data

            try
            {
                String querry = "INSERT INTO Login(Username, Password, Firstname, Lastname) VALUES ('"+username+"', '"+password+"', '"+firstname+"', '"+lastname+"')";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            }
            catch
            {
                MessageBox.Show("error!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AAS backHome = new AAS();
            backHome.Show();
            this.Hide();
        }
    }
}
