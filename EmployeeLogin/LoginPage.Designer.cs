
using System;

namespace EmployeeLogin
{
    partial class EmpLogin
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.LgnLbl = new System.Windows.Forms.Label();
            this.usnLbl = new System.Windows.Forms.Label();
            this.pasLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.dutchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(307, 159);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(211, 26);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(307, 237);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(211, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // LgnLbl
            // 
            this.LgnLbl.AutoSize = true;
            this.LgnLbl.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LgnLbl.Location = new System.Drawing.Point(12, 9);
            this.LgnLbl.Name = "LgnLbl";
            this.LgnLbl.Size = new System.Drawing.Size(136, 52);
            this.LgnLbl.TabIndex = 2;
            this.LgnLbl.Text = "Login";
            // 
            // usnLbl
            // 
            this.usnLbl.AutoSize = true;
            this.usnLbl.Location = new System.Drawing.Point(303, 127);
            this.usnLbl.Name = "usnLbl";
            this.usnLbl.Size = new System.Drawing.Size(89, 20);
            this.usnLbl.TabIndex = 3;
            this.usnLbl.Text = "User Name";
            // 
            // pasLbl
            // 
            this.pasLbl.AutoSize = true;
            this.pasLbl.Location = new System.Drawing.Point(303, 204);
            this.pasLbl.Name = "pasLbl";
            this.pasLbl.Size = new System.Drawing.Size(78, 20);
            this.pasLbl.TabIndex = 4;
            this.pasLbl.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(420, 288);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(98, 33);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(307, 288);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(98, 33);
            this.clrBtn.TabIndex = 6;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // extBtn
            // 
            this.extBtn.Location = new System.Drawing.Point(12, 405);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(89, 33);
            this.extBtn.TabIndex = 7;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // dutchBtn
            // 
            this.dutchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dutchBtn.Image = global::EmployeeLogin.Properties.Resources.dutch_flag_medium;
            this.dutchBtn.Location = new System.Drawing.Point(723, 12);
            this.dutchBtn.Name = "dutchBtn";
            this.dutchBtn.Size = new System.Drawing.Size(65, 49);
            this.dutchBtn.TabIndex = 8;
            this.dutchBtn.Text = ".";
            this.dutchBtn.UseVisualStyleBackColor = true;
            this.dutchBtn.Click += new System.EventHandler(this.dutchBtn_Click);
            // 
            // EmpLogin
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dutchBtn);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pasLbl);
            this.Controls.Add(this.usnLbl);
            this.Controls.Add(this.LgnLbl);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "EmpLogin";
            this.Text = "Employee Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label LgnLbl;
        private System.Windows.Forms.Label usnLbl;
        private System.Windows.Forms.Label pasLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Button dutchBtn;
    }
}

