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
            if (enterPinScreen.Visible)
            {
                Clear();
            }
        }
    }
}
