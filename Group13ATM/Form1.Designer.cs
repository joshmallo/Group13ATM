
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
            this.ATMBtn.Location = new System.Drawing.Point(206, 29);
            this.ATMBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ATMBtn.Name = "ATMBtn";
            this.ATMBtn.Size = new System.Drawing.Size(97, 73);
            this.ATMBtn.TabIndex = 0;
            this.ATMBtn.Text = "ATM";
            this.ATMBtn.UseVisualStyleBackColor = true;
            // 
            // EmpLoginBtn
            // 
            this.EmpLoginBtn.Location = new System.Drawing.Point(46, 96);
            this.EmpLoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EmpLoginBtn.Name = "EmpLoginBtn";
            this.EmpLoginBtn.Size = new System.Drawing.Size(97, 73);
            this.EmpLoginBtn.TabIndex = 1;
            this.EmpLoginBtn.Text = "Employee shit";
            this.EmpLoginBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.EmpLoginBtn);
            this.Controls.Add(this.ATMBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ATMBtn;
        private System.Windows.Forms.Button EmpLoginBtn;
    }
}

