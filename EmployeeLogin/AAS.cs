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
using DarrenLee.Translator;

namespace EmployeeLogin
{
    public partial class AAS : Form
    {
        public AAS()
        {
            InitializeComponent();
        }
        /*public void Run()
        {

            if (EmpLogin.instance.Dutch == true)
            {
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    string dutchText = Translator.Translate(lbl.Text, "en", "nl");
                    lbl.Text = dutchText;
                    lbl.Invalidate();
                    lbl.Update();
                }
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    if (btn.Text.Length > 0)
                    {
                        string dutchButtons = Translator.Translate(btn.Text, "en", "nl");
                        btn.Text = dutchButtons;
                        btn.Invalidate();
                        btn.Update();
                    }
                    else return;
                }
            }
            else if (EmpLogin.instance.German == true)
            {
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    string germanText = Translator.Translate(lbl.Text, "en", "de");
                    lbl.Text = germanText;
                    lbl.Invalidate();
                    lbl.Update();
                }
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    if (btn.Text.Length > 0)
                    {
                        string germanButtons = Translator.Translate(btn.Text, "en", "de");
                        btn.Text = germanButtons;
                        btn.Invalidate();
                        btn.Update();
                    }
                    else return;
                }
            }
            else if (EmpLogin.instance.Spanish == true)
            {
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    string spanishText = Translator.Translate(lbl.Text, "en", "es");
                    lbl.Text = spanishText;
                    lbl.Invalidate();
                    lbl.Update();
                }
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    if (btn.Text.Length > 0)
                    {
                        string spanishButtons = Translator.Translate(btn.Text, "en", "es");
                        btn.Text = spanishButtons;
                        btn.Invalidate();
                        btn.Update();
                    }
                    else return;
                }
            }
            else if (EmpLogin.instance.French == true)
            {
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    string frenchText = Translator.Translate(lbl.Text, "en", "fr");
                    lbl.Text = frenchText;
                    lbl.Invalidate();
                    lbl.Update();
                }
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    if (btn.Text.Length > 0)
                    {
                        string frenchButtons = Translator.Translate(btn.Text, "en", "fr");
                        btn.Text = frenchButtons;
                        btn.Invalidate();
                        btn.Update();
                    }
                    else return;
                }
            }
            else return;
        }*/
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
