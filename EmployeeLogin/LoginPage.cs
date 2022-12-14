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
using DarrenLee.Translator;

namespace EmployeeLogin
{
    public partial class EmpLogin : Form
    {
        public static EmpLogin instance;
        public EmpLogin()
        {
            InitializeComponent();
            instance = this;
        }

        public string Language = "";

        SQLiteConnection con = new SQLiteConnection(Functions.pathToDB());
        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Employee WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SQLiteDataAdapter sda = new SQLiteDataAdapter(querry, con);

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
                con.Close();
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

        private void dutchBtn_Click(object sender, EventArgs e)
        {
            EmpLogin.instance.Language = "Dutch";
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                string dutchText = Translator.Translate(lbl.Text, "en", "nl");
                lbl.Text = dutchText;
                lbl.Invalidate();
                lbl.Update();
            }
            foreach(Button btn in this.Controls.OfType<Button>())
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

        private void germanBtn_Click(object sender, EventArgs e)
        {
            EmpLogin.instance.Language = "German";
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                string dutchText = Translator.Translate(lbl.Text, "en", "de");
                lbl.Text = dutchText;
                lbl.Invalidate();
                lbl.Update();
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Text.Length > 0)
                {
                    string dutchButtons = Translator.Translate(btn.Text, "en", "de");
                    btn.Text = dutchButtons;
                    btn.Invalidate();
                    btn.Update();
                }
                else return;
            }
        }

        private void spanishBtn_Click(object sender, EventArgs e)
        {
            EmpLogin.instance.Language = "Spanish";

            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                string dutchText = Translator.Translate(lbl.Text, "en", "es");
                lbl.Text = dutchText;
                lbl.Invalidate();
                lbl.Update();
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Text.Length > 0)
                {
                    string dutchButtons = Translator.Translate(btn.Text, "en", "es");
                    btn.Text = dutchButtons;
                    btn.Invalidate();
                    btn.Update();
                }
                else return;
            }
        }

        private void frenchBtn_Click(object sender, EventArgs e)
        {
            EmpLogin.instance.Language = "French";
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                string dutchText = Translator.Translate(lbl.Text, "en", "fr");
                lbl.Text = dutchText;
                lbl.Invalidate();
                lbl.Update();
            }
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Text.Length > 0)
                {
                    string dutchButtons = Translator.Translate(btn.Text, "en", "fr");
                    btn.Text = dutchButtons;
                    btn.Invalidate();
                    btn.Update();
                }
                else return;
            }
        }
    }
}
