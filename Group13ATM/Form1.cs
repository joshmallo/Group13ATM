using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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

        private User currentUser;
        private Account accessedAccount; // the current account that the user is accessing
        private int incorrectPins = 0;
        private string option = "";
        private int transactionIndex;
        private double withdrawAmount;
        private Account transferFrom;
               
        void Clear()
        {
            foreach (Panel panel in display.Controls.OfType<Panel>()) { panel.Visible = false; }
            transactionIndex= 0;
            withdrawAmount = 0;
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
                if (log.Items[log.Items.Count-1].Text != "Card swallowed.") { log.Items.Add("Card ejected."); }
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

            if (enterPinScreen.Visible && pinInput.TextLength == 4)
            {
                pinInput.Text = "";
                if (true) // if PIN is correct
                {
                    { // for testing
                        currentUser = new User(new CurrentAccount(22.00), new DepositAccount(10.0), null);
                        currentUser.currentAccount.AddTransaction(new Transaction(currentUser.currentAccount, "12:00 06/12/2022", 10, 200, 210, true));
                        currentUser.currentAccount.AddTransaction(new Transaction(currentUser.currentAccount, "14:00 06/12/2022", 300, 200, 200, false));
                        //currentUser.accounts.Add(new Account("Long-term Account"));
                    }
                    incorrectPins = 0;
                    incorrectPinLabel.Visible = false;
                    Clear();
                    mainMenuScreen.Visible = true;
                }
                else
                {
                    incorrectPinLabel.Visible = true;
                    incorrectPins++;
                    if (incorrectPins == 3) // if user gets PIN wrong 3 times
                    {
                        log.Items.Add("Card swallowed.");
                        pinInput.Enabled = false;
                        incorrectPinLabel.Text = "Account has been locked.\nPlease contact your bank.";
                    }
                    else
                    {
                        incorrectPinLabel.Text = "Pin incorrect. Please try again.";
                        incorrectPinLabel.Text += "\n" + (3 - incorrectPins) + " attempts remaining.";
                    }
                }
            }
            else if (customWithdrawAmountScreen.Visible)
            {
                double amount = 0;
                if (double.TryParse(customWithdrawInput.Text, out amount) && amount % 5 == 0)
                {
                    withdrawAmount = amount;
                    Clear();
                    confirmWithdrawScreen.Visible = true;
                    invalidWithdrawAmountLabel.Visible = false;
                }
                else { invalidWithdrawAmountLabel.Visible = true; }
            }
            else if (transferAmountScreen.Visible)
            {
                double amount = 0;
                if (double.TryParse(transferAmountInput.Text, out amount))
                {
                    Clear();
                    withdrawAmount = amount;
                    confirmTransferScreen.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void left1_Click(object sender, EventArgs e)
        {
            if (mainMenuScreen.Visible)
            {
                Clear();
                selectAccountMenu.Visible = true;
                option = "balance";
            }
        }

        private void left3_Click(object sender, EventArgs e)
        {
            if (mainMenuScreen.Visible)
            {
                Clear();
                log.Items.Add("Card ejected.");
                welcomeScreen.Visible = true;
            }
            if (selectAccountMenu.Visible && currentUser.longTermAccount != null)
            {
                accessedAccount = currentUser.longTermAccount;
                Clear();
                continueFromAccountSelection();
            }
            if (viewTransactionsScreen.Visible) { log.Items.Add("Transaction receipt printed."); }
            else if (withdrawAmountScreen.Visible)
            {
                Clear();
                withdrawAmount = 20;
                confirmWithdrawScreen.Visible = true;
            }
        }

        private void selectAccountMenu_Paint(object sender, PaintEventArgs e)
        {
            if (currentUser.depositAccount == null) { label10.ForeColor = Color.Gray; }
            if (currentUser.currentAccount == null) { label11.ForeColor = Color.Gray; }
            if (currentUser.longTermAccount == null) { label9.ForeColor = Color.Gray; }
        }

        private void right3_Click(object sender, EventArgs e)
        {
            if (selectAccountMenu.Visible || balanceScreen.Visible)
            {
                Clear();
                mainMenuScreen.Visible = true;
            }
            if (viewTransactionsScreen.Visible)
            {
                if (transactionIndex == 10 || transactionIndex == accessedAccount.transactions.Count - 1) { transactionIndex = 0; }
                transactionIndex++;
                Transaction transaction = accessedAccount.transactions[transactionIndex];
                if (transaction.balanceBefore > transaction.balanceAfter) { transactionTypeLabel.Text = "Deposit"; }
                else if(!transaction.success) { transactionTypeLabel.Text = "Unsuccess"; }
                else { transactionTypeLabel.Text = "Withdraw"; }
                transactionAmountLabel.Text = "Amount: £" + transaction.amount;
                transactionDateTimeLabel.Text = transaction.dateTime;
            }
            else if (withdrawAmountScreen.Visible)
            {
                Clear();
                withdrawAmount = 50;
                confirmWithdrawScreen.Visible = true;
            }
        }

        private void left2_Click(object sender, EventArgs e)
        {
            if (selectAccountMenu.Visible && currentUser.currentAccount != null)
            {
                accessedAccount = currentUser.currentAccount;
                Clear();
                continueFromAccountSelection();
            }
            else if (mainMenuScreen.Visible)
            {
                Clear();
                option = "withdraw";
                selectAccountMenu.Visible = true;
            }
            else if (withdrawAmountScreen.Visible)
            {
                Clear();
                withdrawAmount = 5;
                confirmWithdrawScreen.Visible = true; 
            }
            else if (confirmWithdrawScreen.Visible)
            {
                Server.WithdrawCash(accessedAccount, withdrawAmount);
                log.Items.Add("Card ejected.");
                log.Items.Add("Receipt printed.");
                log.Items.Add($"£{withdrawAmount} ejected.");
                Clear();
                welcomeScreen.Visible = true;
            }
            else if (confirmTransferScreen.Visible)
            {
                Server.Transfer(transferFrom, accessedAccount, withdrawAmount);
                log.Items.Add("Transaction receipt printed.");
                Clear();
                mainMenuScreen.Visible = true;
            }
        }

        private void balanceScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (balanceScreen.Visible) { balanceLabel.Text = "£" + accessedAccount.balance; }
        }

        private void right2_Click(object sender, EventArgs e)
        {
            if (selectAccountMenu.Visible && currentUser.depositAccount != null)
            {
                accessedAccount = currentUser.depositAccount;
                continueFromAccountSelection();
            }
            else if (mainMenuScreen.Visible)
            {
                if (mainMenuScreen.Visible)
                {
                    Clear();
                    selectAccountMenu.Visible = true;
                    option = "transactions";
                }
            }
            else if (withdrawAmountScreen.Visible)
            {
                Clear();
                withdrawAmount = 10;
                confirmWithdrawScreen.Visible = true;
            }
            else if (confirmWithdrawScreen.Visible)
            {
                Clear();
                mainMenuScreen.Visible = true;
            }
        }

        private void viewTransactionsScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (viewTransactionsScreen.Visible) 
            {
                int index = 0;
                List<Transaction> transactions = accessedAccount.transactions;
                if (transactions.Count != 0)
                {
                    Transaction transaction = transactions[0];
                    if (transaction.balanceBefore > transaction.balanceAfter) { transactionTypeLabel.Text = "Deposit"; }
                    else if (!transaction.success) { transactionTypeLabel.Text = "Unsuccess"; }
                    else { transactionTypeLabel.Text = "Withdraw"; }
                    transactionAmountLabel.Text = "Amount: £" + transaction.amount;
                    transactionDateTimeLabel.Text = transaction.dateTime;
                }
                else
                {
                    Clear();
                    mainMenuScreen.Visible = true;
                }
            }
        }

        private void right1_Click(object sender, EventArgs e)
        {
            if (mainMenuScreen.Visible)
            {
                Clear();
                option = "transferFrom";
                selectAccountMenu.Visible = true;
            }
        }

        private void continueFromAccountSelection()
        {
            Clear();
            if (option == "balance") { balanceScreen.Visible = true; }
            if (option == "transactions") { viewTransactionsScreen.Visible = true; }
            if (option == "withdraw") { withdrawAmountScreen.Visible = true; }
            if (option == "transferFrom") { selectAccountMenu.Visible = false; option = "transferTo"; selectAccountMenu.Visible = true; transferFrom = accessedAccount; }
            if (option == "transferTo") { transferAmountScreen.Visible = true; }
        }

        private void right4_Click(object sender, EventArgs e)
        {
            if (viewTransactionsScreen.Visible || withdrawAmountScreen.Visible)
            {
                Clear();
                mainMenuScreen.Visible = true;
            }
        }

        private void confirmWithdrawScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (confirmWithdrawScreen.Visible) 
            {
                label26.Text = $"Withdraw £{withdrawAmount} from {accessedAccount.type}";
            }
        }

        private void left4_Click(object sender, EventArgs e)
        {
            if (withdrawAmountScreen.Visible)
            {
                Clear();
                customWithdrawAmountScreen.Visible = true;
            }
        }

        private void selectAccountMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (option == "transferTo") { label12.Text = "Select an account to transfer to: ";}
            else if(option == "transferFrom") { label12.Text = "Select an account to transfer from: "; }
        }

        private void numPadPoint_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in display.Controls.OfType<Panel>().Where(p => p.Visible == true))
            {
                foreach (TextBox tb in panel.Controls.OfType<TextBox>())
                {
                    if (tb.Visible && tb.Enabled && tb.PasswordChar != '•' && !tb.Text.Contains('.'))
                    {
                        tb.Text += ".";
                    }
                }
            }
        }

        private void confirmTransferScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (confirmTransferScreen.Visible)
            {
                label33.Text = $"£{withdrawAmount} from {transferFrom.type} to {accessedAccount.type}";
            }
        }
    }
}
