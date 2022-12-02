﻿
namespace EmployeeLogin
{
    partial class NewCustomer
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
            this.showBtn = new System.Windows.Forms.Button();
            this.customerDataView = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.txt_accountNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_overdraft = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(170, 500);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(235, 33);
            this.showBtn.TabIndex = 28;
            this.showBtn.Text = "Show Current Accounts >>";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // customerDataView
            // 
            this.customerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataView.Location = new System.Drawing.Point(411, 38);
            this.customerDataView.Name = "customerDataView";
            this.customerDataView.RowHeadersWidth = 62;
            this.customerDataView.RowTemplate.Height = 28;
            this.customerDataView.Size = new System.Drawing.Size(693, 495);
            this.customerDataView.TabIndex = 27;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(11, 500);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 33);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "<< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // txt_accountNumber
            // 
            this.txt_accountNumber.Location = new System.Drawing.Point(11, 224);
            this.txt_accountNumber.Name = "txt_accountNumber";
            this.txt_accountNumber.Size = new System.Drawing.Size(172, 26);
            this.txt_accountNumber.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "New Account Number";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(233, 436);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(172, 58);
            this.createAccountBtn.TabIndex = 23;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(11, 141);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(172, 26);
            this.txt_lastName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(12, 77);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(172, 26);
            this.txt_firstName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 40);
            this.label6.TabIndex = 29;
            this.label6.Text = "Peronal Identification \r\nNumber (PIN)";
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(12, 315);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(172, 26);
            this.txt_PIN.TabIndex = 30;
            this.txt_PIN.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Age";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(212, 77);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(172, 26);
            this.txt_age.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(212, 141);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(172, 26);
            this.txt_address.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Annual Salary";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(212, 224);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(172, 26);
            this.txt_salary.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Set Overdraft";
            // 
            // txt_overdraft
            // 
            this.txt_overdraft.FormattingEnabled = true;
            this.txt_overdraft.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000"});
            this.txt_overdraft.Location = new System.Drawing.Point(211, 315);
            this.txt_overdraft.Name = "txt_overdraft";
            this.txt_overdraft.Size = new System.Drawing.Size(173, 28);
            this.txt_overdraft.TabIndex = 39;
            // 
            // NewCustomer
            // 
            this.AcceptButton = this.createAccountBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 545);
            this.Controls.Add(this.txt_overdraft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.customerDataView);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.txt_accountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label1);
            this.Name = "NewCustomer";
            this.Text = "New Customer Account";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DataGridView customerDataView;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox txt_accountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txt_overdraft;
    }
}