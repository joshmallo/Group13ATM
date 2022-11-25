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
using System.Data.SQLite;

namespace EmployeeLogin
{
    public partial class EmpLogin : Form
    {
        public EmpLogin()
        {
            InitializeComponent();
        }
        SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\USER\Desktop\Year2SHU\IntroToSoft\Project\Group13ATM\Databases\Employee.db");

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;

                    AAS aas = new AAS();
                    aas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorrect username or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
