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
    public partial class AAS : Form
    {
        public AAS()
        {
            InitializeComponent();
        }
        if(Dutch == true)
        {

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            EmpLogin loginpg = new EmpLogin();
            loginpg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount newacc = new CreateAccount();
            newacc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
            con.Open();

            string querry = "SELECT * from Customer";
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            customerDataView.DataSource = dt;
        }

        private void newAccountBtn_Click(object sender, EventArgs e)
        {
            NewCustomer newCus = new NewCustomer();
            newCus.Show();
            this.Hide();
        }

        private void cusLgnBtn_Click(object sender, EventArgs e)
        {
            CustomerTransactions cusTr = new CustomerTransactions();
            cusTr.Show();
            this.Hide();
        }
    }
}
