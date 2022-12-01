using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group13ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear()
        {
            welcomeScreen.Visible = false;
            enterPinScreen.Visible = false;
        }

        private void numPad1_Click(object sender, EventArgs e)
        {
            numPadPressed(1);
        }

        private void insertCardBut_Click(object sender, EventArgs e)
        {
            Clear();
            enterPinScreen.Visible = true;
            log.Items.Add("Card inserted.");
            cardNumberInput.Enabled = false;
        }

        void numPadPressed(int num)
        {
            foreach (Panel panel in display.Controls.OfType<Panel>().Where(p => p.Visible == true))
            {
                foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                {
                    if (tb.Visible && tb.Enabled)
                    {
                        tb.Text += num;
                    }
                }
            }
        }

        private void numPad2_Click(object sender, EventArgs e)
        {
            numPadPressed(2);
        }

        private void numPad3_Click(object sender, EventArgs e)
        {
            numPadPressed(3);
        }

        private void numPad4_Click(object sender, EventArgs e)
        {
            numPadPressed(4);
        }

        private void numPad5_Click(object sender, EventArgs e)
        {
            numPadPressed(5);   
        }

        private void numPad6_Click(object sender, EventArgs e)
        {
            numPadPressed(6);
        }

        private void numPad7_Click(object sender, EventArgs e)
        {
            numPadPressed(7);
        }

        private void numPad8_Click(object sender, EventArgs e)
        {
            numPadPressed(8);
        }

        private void numPad9_Click(object sender, EventArgs e)
        {
            numPadPressed(9);
        }

        private void numPad0_Click(object sender, EventArgs e)
        {
            numPadPressed(0);
        }

        private void pinInput_TextChanged(object sender, EventArgs e)
        {
            if (pinInput.Text.Length > 4 ) { pinInput.Text = pinInput.Text.Remove(4, 1); }
        }

        private void numPadClear_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in display.Controls.OfType<Panel>().Where(p => p.Visible == true))
            {
                foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                {
                    if (tb.Visible && tb.Enabled)
                    {
                        tb.Text = "";
                    }
                }
            }
        }

        private void numPadCancel_Click(object sender, EventArgs e)
        {
            if (enterPinScreen.Visible)
            {
                pinInput.Text = "";
                Clear();
                welcomeScreen.Visible = true;
                log.Items.Add("Card ejected.");
            }
        }

        private void numPadEnter_Click(object sender, EventArgs e)
        {
            //Check whether pin matches Customer.db
            //then open new form or clear enterPinScreen and show next actions --
            //1.Review the balance on any account they hold with the bank,
            //2.Withdraw cash from certain accounts,
            //3.Transfer funds between accounts, and
            //4.View a statement of the last ten transactions(i.e., either a withdrawal or a transfer of fund) on a particular account
            //5.Stop using the machine

            //create a tracker for how many times a pin has been entered after 3 attempts they should be locked out
            //once logged in check if transactions table for the account exists if not create one, each time their is a transaction add a field
            //that is headed with the date and the amount give option to show a grid view of their transactions,, when naming the table make sure it is unique to their account

            if (enterPinScreen.Visible)
            {
                Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
