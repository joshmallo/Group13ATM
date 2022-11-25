
namespace EmployeeLogin
{
    partial class CreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(22, 59);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(172, 26);
            this.txt_firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(22, 123);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(172, 26);
            this.txt_lastName.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(230, 59);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(172, 26);
            this.txt_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(230, 123);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(172, 26);
            this.txt_password.TabIndex = 8;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(230, 272);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(172, 58);
            this.createAccountBtn.TabIndex = 9;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 405);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 33);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "<< Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backBtn;
    }
}