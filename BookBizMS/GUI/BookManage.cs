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
    public partial class BookManage : Form
    {
        public BookManage()
        {
            InitializeComponent();
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

        private void buttonAddAuthor_Click(object sender, EventArgs e)
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
                                listBookAuthors.Items.Clear();
                                BookAuthorDA.SearchByBookID(Convert.ToInt32(textBoxInput.Text), listBookAuthors);

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
                            listBookAuthors.Items.Clear();
                            BookAuthorDA.SearchByAuthorID(Convert.ToInt32(textBoxInput.Text), listBookAuthors);

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
                            listBookAuthors.Items.Clear();
                            AuthorDA.SearchByLastName(textBoxInput.Text, listBookAuthors);

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
                            listBookAuthors.Items.Clear();
                            AuthorDA.SearchByEmail(textBoxInput.Text, listBookAuthors);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookManage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxBookID2.Text) && Validator.IsInt(textBoxAuthorID2.Text))
            {
                BookAuthor bookAuthor = new BookAuthor();
                bookAuthor.BookID = Convert.ToInt32(textBoxBookID2.Text);
                bookAuthor.AuthorID = Convert.ToInt32(textBoxAuthorID2.Text);
                BookAuthorDA.AddBookAuthor(bookAuthor);
            }
            else
            {
                MessageBox.Show("Please input an integer for ID!");
            }

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (Validator.IsInt(textBoxBookID.Text) 
                && Validator.IsUniqueID(BookDA.GetListID(), Convert.ToInt32(textBoxBookID.Text)) 
                && textBoxBookName.Text != null
                && Validator.IsLetter(textBoxPublisher.Text) && Validator.IsLetter(textBoxCategory.Text)
                && Validator.IsInt(textBoxInventory.Text) )
            {
                Book book = new Book();
                book.BookID = Convert.ToInt32(textBoxBookID.Text);
                book.ISBN = textBoxISBNNumber.Text;
                book.BookName = textBoxBookName.Text;
                book.Category = textBoxCategory.Text;
                book.YearPublishied = Convert.ToInt32(textBoxYearPublished.Text);
                book.Publisher = textBoxPublisher.Text;
                book.Price = Convert.ToDouble(maskedTextBoxPrice.Text);
                book.Inventory = Convert.ToInt32(textBoxInventory.Text);


                BookDA.AddBook(book);
                ClearAll();

            }
        }

        private void ClearAll()
        {
            textBoxBookID.Clear();
            textBoxISBNNumber.Clear();
            textBoxBookName.Clear();
            textBoxCategory.Clear();
            textBoxYearPublished.Clear();
            textBoxPublisher.Clear();
            maskedTextBoxPrice.Clear();
            textBoxInventory.Clear();

        }
    }
}
