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

namespace BookBizMS.GUI
{
    public partial class AuthorManage : Form
    {
        public AuthorManage()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManage invertoryManage = new InventoryManage();
            invertoryManage.Show();
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

        private void buttonListAuthors_Click(object sender, EventArgs e)
        {
            listAuthors.Items.Clear();
            AuthorDA.ListAuthors(listAuthors);
        }

        public void ClearAll()
        {
            textBoxAuthorID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxInput.Clear();

        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
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
                                listAuthors.Items.Clear();
                                AuthorDA.SearchByAuthorID(Convert.ToInt32(textBoxInput.Text), listAuthors);
                                ClearAll();
                            }
                            else
                            {
                                MessageBox.Show("Inut an Integer please!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inut the AuthorID please!");
                        }
                        break;

                    }
                case 1:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listAuthors.Items.Clear();
                            AuthorDA.SearchByFirstName(textBoxInput.Text, listAuthors);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the First Name please!");
                        }
                        break;
                    }
                case 2:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listAuthors.Items.Clear();
                            AuthorDA.SearchByLastName(textBoxInput.Text, listAuthors);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the Last Name please!");
                        }
                        break;
                    }
               
                case 3:
                    {
                        if (textBoxInput.Text.Length != 0)
                        {
                            listAuthors.Items.Clear();
                            AuthorDA.SearchByEmail(textBoxInput.Text, listAuthors);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Input the Email please!");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxAuthorID.Text)
                && Validator.IsUniqueID(AuthorDA.GetListID(), Convert.ToInt32(textBoxAuthorID.Text)) 
                && Validator.IsLetter(textBoxFirstName.Text)
                && Validator.IsUniqueID(AuthorDA.GetListID(), Convert.ToInt32(textBoxAuthorID.Text))
                && Validator.IsLetter(textBoxLastName.Text) && Validator.IsEmail(textBoxEmail.Text))
            {
                Author author = new Author();
                author.AuthorID = Convert.ToInt32(textBoxAuthorID.Text);
                author.FirstName = textBoxFirstName.Text;
                author.LastName = textBoxLastName.Text;
                author.Email = textBoxEmail.Text;
                AuthorDA.AddAuthor(author);
                ClearAll();
                listAuthors.Items.Clear();
                AuthorDA.ListAuthors(listAuthors);
            }
            else if (!Validator.IsInt(textBoxAuthorID.Text) )
            {
                MessageBox.Show("Input an Integer for AuthorID and UserID please！");
            }
            else if (!(Validator.IsLetter(textBoxFirstName.Text) && Validator.IsLetter(textBoxLastName.Text)))
            {
                MessageBox.Show("First name and last name can only be letters！");
            }
            
            else if (!Validator.IsEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Email is not correct！");
            }
        }
    }
}
