using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeLogin
{
    public partial class AAS : Form
    {
        public AAS()
        {
            InitializeComponent();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            EmpLogin loginpg = new EmpLogin();
            loginpg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount newacc = new CreateAccount();
            newacc.Show();
            this.Hide();
        }
    }
}
