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
    public partial class InventoryManage : Form
    {
        public InventoryManage()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.homePage.Show();
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

        private void buttonUserBook_Click(object sender, EventArgs e)
        {
            BookManage bookManage = new BookManage();
            bookManage.Show();
            this.Close();
        }

        private void buttonAuthorManage_Click(object sender, EventArgs e)
        {

            AuthorManage authorManage = new AuthorManage();
            authorManage.Show();
            this.Close();
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            this.Close();
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
        }


        private void InventoryManage_Load(object sender, EventArgs e)
        {

        }
    }
}
