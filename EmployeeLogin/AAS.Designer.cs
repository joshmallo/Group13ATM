
namespace EmployeeLogin
{
    partial class AAS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newEmpBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.customerDataView = new System.Windows.Forms.DataGridView();
            this.newAccountBtn = new System.Windows.Forms.Button();
            this.cusLgnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Accounts";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(12, 518);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 33);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // newEmpBtn
            // 
            this.newEmpBtn.Location = new System.Drawing.Point(840, 518);
            this.newEmpBtn.Name = "newEmpBtn";
            this.newEmpBtn.Size = new System.Drawing.Size(250, 33);
            this.newEmpBtn.TabIndex = 11;
            this.newEmpBtn.Text = "Create New Employee Account";
            this.newEmpBtn.UseVisualStyleBackColor = true;
            this.newEmpBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(19, 69);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(250, 33);
            this.viewBtn.TabIndex = 12;
            this.viewBtn.Text = "View Customer Data";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerDataView
            // 
            this.customerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataView.Location = new System.Drawing.Point(12, 108);
            this.customerDataView.Name = "customerDataView";
            this.customerDataView.RowHeadersWidth = 62;
            this.customerDataView.RowTemplate.Height = 28;
            this.customerDataView.Size = new System.Drawing.Size(1078, 404);
            this.customerDataView.TabIndex = 13;
            // 
            // newAccountBtn
            // 
            this.newAccountBtn.Location = new System.Drawing.Point(840, 69);
            this.newAccountBtn.Name = "newAccountBtn";
            this.newAccountBtn.Size = new System.Drawing.Size(250, 33);
            this.newAccountBtn.TabIndex = 14;
            this.newAccountBtn.Text = "Create New Customer Account";
            this.newAccountBtn.UseVisualStyleBackColor = true;
            this.newAccountBtn.Click += new System.EventHandler(this.newAccountBtn_Click);
            // 
            // cusLgnBtn
            // 
            this.cusLgnBtn.Location = new System.Drawing.Point(449, 69);
            this.cusLgnBtn.Name = "cusLgnBtn";
            this.cusLgnBtn.Size = new System.Drawing.Size(250, 33);
            this.cusLgnBtn.TabIndex = 15;
            this.cusLgnBtn.Text = "View Customer Transactions";
            this.cusLgnBtn.UseVisualStyleBackColor = true;
            this.cusLgnBtn.Click += new System.EventHandler(this.cusLgnBtn_Click);
            // 
            // AAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 563);
            this.Controls.Add(this.cusLgnBtn);
            this.Controls.Add(this.newAccountBtn);
            this.Controls.Add(this.customerDataView);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.newEmpBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AAS";
            this.Text = "Account Access System";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newEmpBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView customerDataView;
        private System.Windows.Forms.Button newAccountBtn;
        private System.Windows.Forms.Button cusLgnBtn;
    }
}