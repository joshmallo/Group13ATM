
namespace EmployeeLogin
{
    partial class CustomerTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_accountNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.showTransactionsBtn = new System.Windows.Forms.Button();
            this.TransactionsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 518);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 33);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "<< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Account Number";
            // 
            // txt_accountNum
            // 
            this.txt_accountNum.Location = new System.Drawing.Point(16, 32);
            this.txt_accountNum.Name = "txt_accountNum";
            this.txt_accountNum.Size = new System.Drawing.Size(195, 26);
            this.txt_accountNum.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "PIN";
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(16, 94);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(195, 26);
            this.txt_PIN.TabIndex = 17;
            this.txt_PIN.UseSystemPasswordChar = true;
            // 
            // showTransactionsBtn
            // 
            this.showTransactionsBtn.Location = new System.Drawing.Point(16, 140);
            this.showTransactionsBtn.Name = "showTransactionsBtn";
            this.showTransactionsBtn.Size = new System.Drawing.Size(195, 44);
            this.showTransactionsBtn.TabIndex = 18;
            this.showTransactionsBtn.Text = "Show Transactions";
            this.showTransactionsBtn.UseVisualStyleBackColor = true;
            this.showTransactionsBtn.Click += new System.EventHandler(this.showTransactionsBtn_Click);
            // 
            // TransactionsGridView
            // 
            this.TransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsGridView.Location = new System.Drawing.Point(239, 16);
            this.TransactionsGridView.Name = "TransactionsGridView";
            this.TransactionsGridView.RowHeadersWidth = 62;
            this.TransactionsGridView.RowTemplate.Height = 28;
            this.TransactionsGridView.Size = new System.Drawing.Size(849, 535);
            this.TransactionsGridView.TabIndex = 19;
            // 
            // CustomerTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 563);
            this.Controls.Add(this.TransactionsGridView);
            this.Controls.Add(this.showTransactionsBtn);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_accountNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "CustomerTransactions";
            this.Text = "CustomerTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_accountNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PIN;
        private System.Windows.Forms.Button showTransactionsBtn;
        private System.Windows.Forms.DataGridView TransactionsGridView;
    }
}