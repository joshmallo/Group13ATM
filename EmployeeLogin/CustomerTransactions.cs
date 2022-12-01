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
    public partial class CustomerTransactions : Form
    {
        public CustomerTransactions()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AAS bck = new AAS();
            bck.Show();
            this.Hide();
        }

        private void showTransactionsBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\USER\Desktop\Year2SHU\IntroToSoft\Project\Group13ATM\Databases\Employee.db");
            con.Open();
            int accNum, PIN;
            accNum = Convert.ToInt32(txt_accountNum.Text);
            PIN = Convert.ToInt32(txt_PIN.Text);

            try
            {
                string sqlcmd = "SELECT * FROM Customer WHERE AccountNum = '" + accNum + "' AND PIN = '" + PIN + "'";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sqlcmd, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    //string sqlcmd2 = "SELECT * FROM " + txt_accountNum.Text + "1Transactions";
                    string sqlcmd2 = "SELECT * FROM Transactions_" + accNum;
                    SQLiteCommand cmd2 = new SQLiteCommand(sqlcmd2, con);
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
                    adapter2.Fill(dt2);
                    TransactionsGridView.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("incorrect account number or PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_PIN.Clear();
                    txt_accountNum.Clear();
                    txt_accountNum.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
            con.Close();
            }
        }
    }
}
