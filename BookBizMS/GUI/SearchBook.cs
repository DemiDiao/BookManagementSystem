using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBizMS.BLL;
using BookBizMS.DAL;
using BookBizMS.Validation;
using System.IO;

namespace BookBizMS.GUI
{
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

       
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoice.SelectedIndex;
            switch (choice)
            {
                case -1:
                    {  // IF the user NOT select any search option

                        MessageBox.Show("Please, select at least one Search Option");
                        break;
                    }
                case 0:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            if (Validator.IsInt(textBoxInput.Text))
                            {
                                listBooks.Items.Clear();
                                listAuthors.Items.Clear();
                                BookDA.SearchByBookID(Convert.ToInt32(textBoxInput.Text), listBooks, listAuthors);
                                List<int> authorIDList = new List<int>();
                                authorIDList = BookDA.SearchAuthorIDByBookID(Convert.ToInt32(textBoxInput.Text));
                                AuthorDA.listAuthorsByList(authorIDList, listAuthors);
                            }
                            else
                            {
                                MessageBox.Show("Inut an Integer please!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inut the BookID please!");
                        }
                        break;

                    }
                
                
                case 1:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listBooks.Items.Clear();
                            listAuthors.Items.Clear();
                            BookDA.SearchByAuthorID(Convert.ToInt32(textBoxInput.Text), listBooks);
                            AuthorDA.SearchByAuthorID(Convert.ToInt32(textBoxInput.Text), listAuthors);
                           
                        }
                        else
                        {
                            MessageBox.Show("Input the Author ID please!");
                        }
                        break;
                    }
                
                default:
                    {
                        break;
                    }

            }

        }

        private void buttonListBooks_Click(object sender, EventArgs e)
        {
            listBooks.Items.Clear();
            listAuthors.Items.Clear();
            BookDA.ListBooks(listBooks);
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManage inventoryManage = new InventoryManage();
            inventoryManage.Show();
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
