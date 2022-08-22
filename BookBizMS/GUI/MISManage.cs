using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMS.GUI
{
    public partial class MISManage : System.Windows.Forms.Form
    {
        public MISManage()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homePage.Show();
        }

        private void buttonUserManage_Click(object sender, EventArgs e)
        {
            
            UserManage userManage = new UserManage();
            userManage.Show();
            this.Close();

        }

        private void MISManage_Load(object sender, EventArgs e)
        {

        }

        private void buttonEmployeeManage_Click(object sender, EventArgs e)
        {
            
            EmployeeManage userManage = new EmployeeManage();
            userManage.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
