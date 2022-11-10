
namespace Group13ATM
{
    partial class Form1
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
            this.ATMBtn = new System.Windows.Forms.Button();
            this.EmpLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ATMBtn
            // 
            this.ATMBtn.Location = new System.Drawing.Point(309, 45);
            this.ATMBtn.Name = "ATMBtn";
            this.ATMBtn.Size = new System.Drawing.Size(146, 112);
            this.ATMBtn.TabIndex = 0;
            this.ATMBtn.Text = "ATM";
            this.ATMBtn.UseVisualStyleBackColor = true;
            // 
            // EmpLoginBtn
            // 
            this.EmpLoginBtn.Location = new System.Drawing.Point(309, 186);
            this.EmpLoginBtn.Name = "EmpLoginBtn";
            this.EmpLoginBtn.Size = new System.Drawing.Size(146, 112);
            this.EmpLoginBtn.TabIndex = 1;
            this.EmpLoginBtn.Text = "Employee Login";
            this.EmpLoginBtn.UseVisualStyleBackColor = true;
            this.EmpLoginBtn.Click += new System.EventHandler(this.EmpLoginBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.EmpLoginBtn);
            this.Controls.Add(this.ATMBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ATMBtn;
        private System.Windows.Forms.Button EmpLoginBtn;
    }
}

